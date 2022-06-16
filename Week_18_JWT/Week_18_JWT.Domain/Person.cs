using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_18_JWT.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        public double Salary { get; set; }
        public double WorkExperince { get; set; }
        public DateTime CreateDate { get; set; }
        public int AddressId { get; set; }
      }
}
