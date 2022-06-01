using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Week_13.Models;

namespace Week_13.Services
{
    public class MyService : IBaseService
    {
        private string filePath = @"C:\Users\user\source\repos\Week_13\Week_13\Services\MyFiles\UsersJsonFile.json";
        public void AddUser(UserViewModel user)
        {
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<UserViewModel>>(jsonData) ?? new List<UserViewModel>();

            // Add any new user
            userList.Add(user);

            // Update json data string
            jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }

        public List<UserViewModel> GetUsers()
        {
            // Read existing json data
            var jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            var userList = JsonConvert.DeserializeObject<List<UserViewModel>>(jsonData)
                                  ?? new List<UserViewModel>();
            return userList;
        }

        public string ValidationTime(UserViewModel userViewModel)
        {

            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 00, 00);
            var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 00, 00);
            var currentDate = userViewModel.Time;

            if (userViewModel == null)
            {
                return "Pleas input values.";
            }
            if (startDate.Hour > currentDate.Hour || currentDate.Hour > endDate.Hour)
            {
                return "Pleas input correct time.";
            }
            return null;
        }
    }
}
