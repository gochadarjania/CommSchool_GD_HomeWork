using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_18_JWT.Domain
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserWithRole> UserWithRoles { get; set; }
    }
}
