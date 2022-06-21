using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Domain;

namespace Week_17.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) :
            base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person{Id=3,FirstName = "TestName1", LastName = "TestLastName1", CreateDate = DateTime.Now, AddressId = 4, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person{ Id = 4, FirstName = "TestName2", LastName = "TestLastName2", CreateDate = DateTime.Now, AddressId = 5, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person{ Id = 5, FirstName = "TestName3", LastName = "TestLastName3", CreateDate = DateTime.Now, AddressId = 3, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 }
            );
            modelBuilder.Entity<Address>().HasData(
                new Address {Id = 3, Country = "Georgia", City="Tbilisi", HomeNumber = "55223366" },
                new Address { Id = 4, Country = "Georgia", City="Khutaisi", HomeNumber = "55223366" },
                new Address { Id = 5, Country = "Georgia", City="Batumi", HomeNumber = "55223366" }
            );
        }
    }
}
