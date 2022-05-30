using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Week_13.Models;

namespace Week_13.Services
{
    public class MyService : IBaseService
    {
        public void AddUser(UserViewModel user)
        {
            var filePath = @"C:\Users\user\source\repos\Week_13\Week_13\Services\MyFiles\UsersJsonFile.json";
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var employeeList = JsonConvert.DeserializeObject<List<UserViewModel>>(jsonData)
                                  ?? new List<UserViewModel>();

            // Add any new employees
            employeeList.Add(user);

            // Update json data string
            jsonData = JsonConvert.SerializeObject(employeeList);
            System.IO.File.WriteAllText(filePath, jsonData);
        }

        public List<UserViewModel> GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}
