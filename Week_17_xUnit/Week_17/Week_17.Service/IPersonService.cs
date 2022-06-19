using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Domain;

namespace Week_17.Service
{
    public interface IPersonService
    {
        Task<List<Person>> GetPersons();//Get Person List
        Task<Person> AddPerson(Person person);//Add Person in List
        Task<Person> GetPersonById(int id);//Get Person By Id From List
        Task<List<Person>> DeletePersonById(int id);//Delete Person By Id From List
        Task<List<Person>> GetPersonsByQuery(string query);//get list by city or countri
        Task<List<Person>> UpdatePerson(Person person);//get list by city or countri
    }
}
