using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Daomain;
using Week_17.Data;

namespace Week_17.Services
{
    public class PersonService : IPersonService
    {
        private MyDbContext _context;
        public PersonService(MyDbContext context)
        {
            _context = context;
        }

        public async void AddPerson(Person person)
        {
            List<Person> list = new List<Person>();
            list.Add(person);
            await _context.Persons.AddAsync(person);
            await _context.SaveChangesAsync();
        }

        public async void DeletePerson(int id)
        {
            var person = await GetPersonById(id);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
        }

        public async Task<Person> GetPersonById(int id)
        {
           var person = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);

            return person;
        }

        public Task<List<Person>> GetPersons()
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetPersonsByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonsById(Person person, int id)
        {
            throw new NotImplementedException();
        }
    }
}
