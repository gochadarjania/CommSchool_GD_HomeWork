using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_17.Controllers;
using Week_17.Domain;
using Week_17.Service;
using Xunit;

namespace Week_17_Tests
{
    public class PersonServiceControllerTest
    {
        public Mock<IPersonService> mock = new Mock<IPersonService>();

        [Fact]
        public async void GetPersonById()
        {
            var person = new Person()
            {
                Id = 1,
                FirstName = "JK",
                LastName = "SDE"
            };

            mock.Setup(p => p.GetPersonById(1)).ReturnsAsync(person);
            var personController = new PersonController(mock.Object);
            var result = await personController.GetPersonById(1);

            Assert.True(person.Equals(result));
        }

    }
}
