using Microsoft.AspNetCore.Mvc;
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
		private readonly PersonController _controller;
		private readonly IPersonService _service;
		public PersonServiceControllerTest()
		{
			_service = new PersonServiceFake();
			_controller = new PersonController(_service);
		}

		[Fact]
		public void GetById_UnknownGuidPassed_ReturnsNotFoundResult()
		{
			//Arrange
			int id = 52;

			// Arrange+ Act
			var notFoundResult = _controller.GetPersonById(id);

			// Assert
			Assert.IsType<NotFoundResult>(notFoundResult);
		}

		[Fact]
		public void Add_InvalidObjectPassed_ReturnsBadRequest()
		{
			// Arrange
			var nameMissingItem = new Person()
			{
				Id = 8,
				FirstName = "zxxz",
				LastName = "Dila0",
				AddressId = 1,
				Salary = 550,
				 CreateDate = DateTime.Now,
				 JobPosition = "Dev",
				 WorkExperince = 25
			};
			_controller.ModelState.AddModelError("FirstName", "Required");

			// Act
			var badResponse = _controller.AddPerson(nameMissingItem);

			// Assert
			Assert.IsType<BadRequestObjectResult>(badResponse);
		}

		[Fact]
		public void Remove_NotExistingGuidPassed_ReturnsNotFoundResponse()
		{
			// Arrange
			var notExistingGuid = 83;

			// Act
			var badResponse = _controller.DeletePersonById(notExistingGuid);

			// Assert
			Assert.IsType<NotFoundResult>(badResponse);
		}

		[Fact]
		public async Task Remove_ExistingGuidPassed_RemovesOneItem()
		{
			// Arrange
			var existingGuid = 1;

			// Act
			await _controller.DeletePersonById(existingGuid);

			// Assert
			Assert.Equal(1, _service.GetPersons().Result.Count);
		}
	}
}
