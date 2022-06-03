using System.Collections.Generic;
using System.IO;
using System;
using Week_14.Models;
using Newtonsoft.Json;
using System.Linq;

namespace Week_14.Services
{
    public class MyService : IMyService
    {
        private string filePath = @"C:\Users\user\source\repos\Week_14\Week_14\Services\Files\Persons.json";

        public void AddPerson(Person person)
        {
            // Read existing json data
            var jsonData = File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<Person>>(jsonData) ?? new List<Person>();

            // Add any new user
            userList.Add(person);

            // Update json data string
            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }

        public List<Person> GetPersons()
        {
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<Person>>(jsonData)
                                  ?? new List<Person>();
            return userList;
        }

        public List<Person> GetPersonsByQuery(string query)
        {
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<Person>>(jsonData)
                                  ?? new List<Person>();
            var resultList = userList.Where(x => 
                                                x.PersonAddress.City.Contains(query) || 
                                                x.PersonAddress.Country.Contains(query)).ToList();
            return resultList;
        }

        public Person GetPersonById(int id)
        {
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<Person>>(jsonData)
                                  ?? new List<Person>();
            var person = userList.FirstOrDefault(x => x.Id == id);
            return person;
        }
        public void DeletePerson(int id)
        {
            // Read existing json data
            var jsonData = File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<Person>>(jsonData) ?? new List<Person>();

            var person = userList.FirstOrDefault(x => x.Id == id);

            // Delete any new user
            userList.Remove(person);

            // Update json data string
            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }

        public void UpdatePersonsById(Person person, int id)
        {
            var userList = GetPersons();

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Id== id)
                {
                    userList[i] = person;
                }
            }

            // Update json data string
            var jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);        }

    }
}
