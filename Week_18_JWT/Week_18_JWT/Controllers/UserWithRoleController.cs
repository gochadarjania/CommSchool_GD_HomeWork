using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Week_18.Domain.Validation;
using Week_18_JWT.Data;
using Week_18_JWT.Domain;
using Week_18_JWT.Helpers;
using Week_18_JWT.Service.Interface;

namespace Week_18_JWT.Controllers
{

	[Authorize]
	[Route("api/[controller]")]
	public class UserWithRoleController : Controller
	{
		private IUserServiceWithRole _userService;
		private readonly AppSettings _appSettings;
        private UserDbContext _context;
		public UserWithRoleController(
		IUserServiceWithRole userService,
		IOptions<AppSettings> appSettings,
        UserDbContext context
        )
		{
			_userService = userService;
			_appSettings = appSettings.Value;
            _context = context;
		}

		[AllowAnonymous]
		[HttpPost("login")]
		public IActionResult Login([FromBody] UserWithRole userModel)
		{

			var user = _userService.Login(userModel);

			if (user == null)
				return BadRequest(new { message = "Username or Password is incorrect" });

			var role = _userService.GetRoleByUser(user.Id);
			string tokenString = GenerateToken(user, role);

			return Ok(new
			{
				Id = user.Id,
				Username = user.Username,
				FirstName = user.FirstName,
				LastName = user.LastName,
				Role = role.RoleName,
				Token = tokenString
			});

		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult GetAllUsers()
		{
			var users = _userService.GetAll();
			return Ok(users);

		}


        [HttpPost("AddPerson")]
        public async Task<ActionResult> AddPerson(Person person)
        {
            var errors = new List<string>();
            var validator = new PersonValidator();
            var results = validator.Validate(person);

            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
            }

            if (errors.Count > 0)
            {
                return BadRequest(errors);
            }

            await _context.AddAsync(person);
            await _context.SaveChangesAsync();

            return Ok(person);
        }

        [HttpGet("GetPersons")]
        public async Task<ActionResult<Person>> GetPersons()
        {
            var personList = await _context.Persons.Select(x => x).ToListAsync();
            return Ok(personList);
        }

        [HttpGet("GetPersonById")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _context.Persons.Where(x => x.Id == id).FirstOrDefaultAsync();
            return Ok(person);
        }

        [HttpGet("GetPersonByQuery")]
        public async Task<ActionResult> GetPersonByQuery(string queryCity, string queryName)
        {
            var persons = (from p in _context.Persons
                           join a in _context.Addresses on p.AddressId equals a.Id
                           where a.City.Contains(queryCity) && p.FirstName.Contains(queryName)
                           select new { a.City, p.FirstName, p.LastName, p.Salary });

            var resultPersons = await persons.ToListAsync();
            return Ok(resultPersons);
        }

        [HttpDelete("DeletePersonById")]
        public async Task<ActionResult<Person>> DeletePersonById(int id)
        {
            var person = await _context.Persons.Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            var personList = await _context.Persons.Select(x => x).ToListAsync();

            return Ok(personList);
        }

        [HttpPut("UpdatePersons")]
        public async Task<ActionResult<Person>> UpdatePersons(Person person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();

            var personList = await _context.Persons.Select(x => x).ToListAsync();
            return Ok(personList);
        }

        private string GenerateToken(UserWithRole user,Role role)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.Name, user.Id.ToString()),
					new Claim(ClaimTypes.Role, role.RoleName.ToString())
				}),
				Expires = DateTime.UtcNow.AddDays(1),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			var tokenString = tokenHandler.WriteToken(token);
			return tokenString;
		}
	}
}
