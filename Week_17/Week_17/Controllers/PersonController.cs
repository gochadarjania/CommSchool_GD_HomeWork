using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_17.Daomain;
using Week_17.Data;
using Week_17.Domain.Validation;
using myLinq = NHibernate.Linq;

namespace Week_17.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        MyDbContext _context;
        public PersonController(MyDbContext context)
        {
            _context = context;
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
        public async Task<ActionResult<List<Person>>> GetPersons()
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
    }
}
