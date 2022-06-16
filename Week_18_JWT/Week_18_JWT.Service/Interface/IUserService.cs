using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_18_JWT.Service.Interface
{
    public interface IUserService
    {
        string UserLogin(string username, string password);
    }
}
