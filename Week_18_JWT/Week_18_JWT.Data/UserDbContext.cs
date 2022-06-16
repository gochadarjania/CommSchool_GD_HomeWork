using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_18_JWT.Domain;

namespace Week_18_JWT.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) :
            base(options)
        {

        }

        public DbSet<UserWithRole> UserWithRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, Country = "Georgia", City = "Tbilisi", HomeNumber = "55223366" },
                new Address { Id = 2, Country = "Georgia", City = "Khutaisi", HomeNumber = "55223366" },
                new Address { Id = 3, Country = "Georgia", City = "Batumi", HomeNumber = "55223366" }
            );
            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 3, FirstName = "TestName1", LastName = "TestLastName1", CreateDate = DateTime.Now, AddressId = 1, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person { Id = 4, FirstName = "TestName2", LastName = "TestLastName2", CreateDate = DateTime.Now, AddressId = 2, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 },
                new Person { Id = 5, FirstName = "TestName3", LastName = "TestLastName3", CreateDate = DateTime.Now, AddressId = 3, JobPosition = "Junior Developer", Salary = 500, WorkExperince = 1 }
            );

            modelBuilder.Entity<UserWithRole>().HasData(
                new UserWithRole() { Id = 1, FirstName = "Test First 1", LastName = "Test Last 1", Password = "test123", Username = "test123" },
                new UserWithRole() { Id = 2, FirstName = "Test First 2", LastName = "Test Last 2", Password = "test123", Username = "test123" },
                new UserWithRole() { Id = 3, FirstName = "Test First 3", LastName = "Test Last 3", Password = "test123", Username = "test123" },
                new UserWithRole() { Id = 4, FirstName = "Test First 4", LastName = "Test Last 4", Password = "test123", Username = "test123" }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "SuperAdmin" },
                new Role { Id = 2, RoleName = "Admin" },
                new Role { Id = 3, RoleName = "ReportsAdmin" }
                );

        }


    }
}
