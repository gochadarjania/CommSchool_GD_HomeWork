using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_17.Domain;
using Week_17.Data;
using myLinq = NHibernate.Linq;
using Week_17.Service;


namespace Week_17.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        IPersonService _context;
        public PersonController(IPersonService context)
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

            var returnPerson = await _context.AddPerson(person);

            return Ok(returnPerson);
        }

        [HttpGet]
        public async Task<ActionResult<Person>> GetPersons()
        {
            var personList = await _context.GetPersons();
            return Ok(personList);
        }

        [HttpGet(nameof(GetPersonById))]
        public async Task<Person> GetPersonById(int id)
        {
            var person = await _context.GetPersonById(id);
            return person;
        }

        [HttpGet("GetPersonByQuery")]
        public async Task<ActionResult> GetPersonByQuery(string query)
        {
            var resultPersons = await _context.GetPersonsByQuery(query);
            return Ok(resultPersons);
        }

        [HttpDelete("DeletePersonById")]
        public async Task<ActionResult<Person>> DeletePersonById(int id)
        {
            var personList = await _context.DeletePersonById(id);

            return Ok(personList);
        }

        //[HttpPut("UpdatePersons")]
        //public async Task<ActionResult<Person>> UpdatePersons(Person person)
        //{
        //    var personList = await _context.UpdatePerson(person);
        //    return Ok(personList);
        //}

        public async Task<IActionResult> Update(int id)
        {
            Person person = await _context.GetPersonById(id);
            return View(person);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Person person)
        {
            if (ModelState.IsValid)
            {
                await _context.UpdatePerson(person);
                ViewBag.Result = "Success";
            }
            return View(person);
        }
    }
}
