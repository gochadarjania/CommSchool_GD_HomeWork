using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Daomain;

namespace Week_17.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetPersons();//Get Person List
        void AddPerson(Person person);//Add Person in List
        Task<Person> GetPersonById(int id);//Get Person By Id From List
        void DeletePerson(int id);//Delete Person By Id From List
        Task<List<Person>> GetPersonsByQuery(string query);//get list by city or countri
        void UpdatePersonsById(Person person, int id);//get list by city or countri
    }
}
