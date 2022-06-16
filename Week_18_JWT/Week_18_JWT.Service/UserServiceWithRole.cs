using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_18_JWT.Data;
using Week_18_JWT.Domain;
using Week_18_JWT.Service.Interface;

namespace Week_18_JWT.Service
{
    public class UserServiceWithRole : IUserServiceWithRole
	{
		UserDbContext _userDbContext;
        public UserServiceWithRole(UserDbContext userDbContext)
        {
			_userDbContext = userDbContext;
        }
		public IEnumerable<UserWithRole> GetAll()
		{
			return _userDbContext.UserWithRoles;
		}

		public UserWithRole GetById(int id)
		{
			return _userDbContext.UserWithRoles.FirstOrDefault(x => x.Id == id);
		}

        public Role GetRoleByUser(int id)
        {
			
            var role = (from r in _userDbContext.Roles
                       where r.UserWithRoles.Any(x => x.Id == id)
					   select r).FirstOrDefault();



			return role;
        }

        public UserWithRole Login(UserWithRole loginModel)
		{
			if (string.IsNullOrEmpty(loginModel.Username) || string.IsNullOrEmpty(loginModel.Password))
				return null;

			var user = _userDbContext.UserWithRoles.FirstOrDefault(x => x.Username == loginModel.Username);

			if (user == null)
				return null;

			if (loginModel.Password != user.Password)
				return null;

			return user;
		}
	}
}
