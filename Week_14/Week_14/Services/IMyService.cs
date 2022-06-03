using System.Collections.Generic;
using Week_14.Models;

namespace Week_14.Services
{
    public interface IMyService
    {
        List<Person> GetPersons();//Get Person List
        void AddPerson(Person person);//Add Person in List
        Person GetPersonById(int id);//Get Person By Id From List
        void DeletePerson(int id);//Delete Person By Id From List
        List<Person> GetPersonsByQuery(string query);//get list by city or countri
        void UpdatePersonsById(Person person, int id);//get list by city or countri
    }
}
