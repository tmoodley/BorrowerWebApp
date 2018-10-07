using BorrowerRegistrationApplication.Controllers;
using Data;
using EntityFrameworkCore;
using Interfaces; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Logging; 
using Moq; 
using Services; 
using Xunit;

namespace XUnitTestProject1
{
	public class BorrowerTest
	{  
		public BorrowerTest()
		{ 
		}
		   
		[Fact]
		public void TestGetBorrowers()
		{
			//Arrange
		    var mockRepo = new Mock<IBorrowerRepository>();
			  
			// Act
			var result = mockRepo.Object.GetAll();

			//// Assert 
			Assert.Null(result);
		}

		[Fact]
		public void TestGetRandomBorrower()
		{
			//Arrange
			var mockObj = new Mock<Borrower>();
			var mockRepo = new Mock<IBorrowerRepository>();
			var mockService = new Mock<IBorrowerService>();

			// Act
			var result = mockService.Object.GetById(new System.Guid());

			//// Assert 
			Assert.Null(result);
		}
	}
}
