using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Domain;
using Week_17.Service;

namespace Week_17_Tests
{
    public class PersonServiceFake : IPersonService
    {
        private List<Person> _persons;

        public PersonServiceFake()
        {
            _persons = new List<Person>()
            {
                new Person{Id=3,FirstName = "TestName1", LastName = "TestLastName1", CreateDate = DateTime.Now, AddressId = 4, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person{ Id = 4, FirstName = "TestName2", LastName = "TestLastName2", CreateDate = DateTime.Now, AddressId = 5, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person{ Id = 5, FirstName = "TestName3", LastName = "TestLastName3", CreateDate = DateTime.Now, AddressId = 3, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 }
            };
        }

        public async Task<List<Person>> GetPersons()
        {
            return _persons;
        }
        public async Task<List<Person>> UpdatePerson(Person person)
        {
            List<Person> persons = new List<Person>();
            foreach (var item in _persons)
            {
                if (item.Id == person.Id)
                {
                    item.FirstName = person.FirstName;
                    item.LastName = person.LastName;
                    item.Salary = person.Salary;
                }
                persons.Add(item);
            }
            
            return persons;
        }

        public async Task<Person> AddPerson(Person newItem)
        {
            newItem.Id = 4;
            _persons.Add(newItem);
            return newItem;
        }

        public async Task<Person> GetPersonById(int id)
        {
            return _persons.Where(a => a.Id == id)                .FirstOrDefault();
        }

        public async Task<List<Person>> GetPersonsByQuery(string query)
        {
            var persons = (from p in _persons
                           where p.FirstName.Contains(query) || p.LastName.Contains(query)
                           select new Person
                           {
                               FirstName = p.FirstName,
                               LastName = p.LastName,
                               Salary = p.Salary
                           }).ToList();
            return persons;
        }

        public async Task<List<Person>> DeletePersonById(int id)
        {
            var existing = _persons.First(a => a.Id == id);
            _persons.Remove(existing);
            return _persons;
        }
    }
}
