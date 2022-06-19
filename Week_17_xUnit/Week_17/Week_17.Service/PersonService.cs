using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Domain;
using Week_17.Data;
using Microsoft.EntityFrameworkCore;

namespace Week_17.Service
{
    public class PersonService : IPersonService
    {
        private MyDbContext _context;
        public PersonService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Person> AddPerson(Person person)
        {
            await _context.AddAsync(person);
            await _context.SaveChangesAsync();

            return person;
        }

        public async Task<List<Person>> DeletePersonById(int id)
        {
            var person = await _context.Persons.Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            var personList = await _context.Persons.Select(x => x).ToListAsync();

            return personList;
        }

        public async Task<Person> GetPersonById(int id)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);
            return person;
        }

        public async Task<List<Person>> GetPersons()
        {
            var personList = await _context.Persons.Select(x => x).ToListAsync();
            return personList;
        }

        public async Task<List<Person>> GetPersonsByQuery(string query)
        {
            var persons = await (from p in _context.Persons
                                 join a in _context.Addresses on p.AddressId equals a.Id
                                 where a.City.Contains(query) || p.FirstName.Contains(query)
                                 select new Person{
                                    FirstName = p.FirstName,
                                     LastName = p.LastName,
                                     Salary = p.Salary }).ToListAsync();

            return persons;
        }

        public async Task<List<Person>> UpdatePerson(Person person)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();

            var personList = await _context.Persons.Select(x => x).ToListAsync();
            return personList;
        }
    }
}
