using BorrowerRegistrationApplication.Controllers; 
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
		public void TestGetBookById()
		{
			//Arrange
		    var mockRepo = new Mock<IBorrowerRepository>();
			  
			// Act
			var result = mockRepo.Object.GetAll();

			//// Assert 
			Assert.Null(result);
		}
		 
	}
}
