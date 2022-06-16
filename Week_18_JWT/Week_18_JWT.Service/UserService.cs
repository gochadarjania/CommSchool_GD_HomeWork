using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_18_JWT.Data;
using Week_18_JWT.Service.Interface;

namespace Week_18_JWT.Service
{
    public class UserService : IUserService
    {
        UserDbContext _context;
        public UserService(UserDbContext context)
        {
            _context = context;
        }
        public string UserLogin(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
