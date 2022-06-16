using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_18_JWT.Domain;

namespace Week_18_JWT.Service.Interface
{
    public interface IUserServiceWithRole
    {
        UserWithRole Login(UserWithRole model);
        Role GetRoleByUser(int id);
        UserWithRole GetById(int id);
        IEnumerable<UserWithRole> GetAll();
    }
}
