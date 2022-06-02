using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Week_14.Models;
using Week_14.Services;

namespace Week_14.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        IMyService _myService;
        public PersonController(IMyService myService)
        {
            _myService = myService;
        }
        [HttpPost("AddPerson")]
        public IActionResult AddPerson(Person person)
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

            _myService.AddPerson(person);

            return Ok(person);
        }
        [HttpGet("GetPersons")]
        public IActionResult GetPersons()
        {
            return Ok(_myService.GetPersons());
        }

        [HttpGet("GetPersonById")]
        public IActionResult GetPersonById(int id)
        {

            return Ok(_myService.GetPersonById(id));
        }

        [HttpGet("GetPersonByQuery")]
        public IActionResult GetPersonByQuery(string query)
        {

            return Ok(_myService.GetPersonsByQuery(query));
        }

        [HttpDelete("DeletePersonById")]
        public IActionResult DeletePersonById(int id)
        {
            _myService.DeletePerson(id);
            return Ok(_myService.GetPersons());
        }

        [HttpPut("UpdatePersonsById")]
        public IActionResult UpdatePersonsById(Person person, int id)
        {
            _myService.UpdatePersonsById(person,id);
            return Ok(_myService.GetPersons());
        }

    }
}
