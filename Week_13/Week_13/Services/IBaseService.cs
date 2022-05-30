using System.Collections.Generic;
using Week_13.Models;

namespace Week_13.Services
{
    public interface IBaseService
    {
        public List<UserViewModel> GetUsers();
        public void AddUser(UserViewModel user);
    }
}
