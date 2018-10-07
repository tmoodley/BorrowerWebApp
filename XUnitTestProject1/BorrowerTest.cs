using Data;
using Interfaces; 
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

		[Fact]
		public void TestBlankEmailBorrower()
		{
			//Arrange
			var mockObj = new Mock<Borrower>();
			mockObj.Object.FirstName = "Test";
			mockObj.Object.LastName = "Mo";
			mockObj.Object.Gender = "Male";
			mockObj.Object.Password = "23423";
			mockObj.Object.Login = "";

			var mockRepo = new Mock<IBorrowerRepository>();
			var mockService = new Mock<IBorrowerService>();

			// Act
			var result = mockService.Object.Create(mockObj.Object);

			//// Assert 
			Assert.False(result);
		}

		[Fact]
		public void TestBlankFirstNameBorrower()
		{
			//Arrange
			var mockObj = new Mock<Borrower>();
			mockObj.Object.FirstName = "";
			mockObj.Object.LastName = "Mo";
			mockObj.Object.Gender = "Male";
			mockObj.Object.Password = "23423";
			mockObj.Object.Login = "ty.mo@gmail.com";

			var mockRepo = new Mock<IBorrowerRepository>();
			var mockService = new Mock<IBorrowerService>();

			// Act
			var result = mockService.Object.Create(mockObj.Object);

			//// Assert 
			Assert.False(result);
		}

		[Fact]
		public void TestBlankLastNameBorrower()
		{
			//Arrange
			var mockObj = new Mock<Borrower>();
			mockObj.Object.FirstName = "Test";
			mockObj.Object.LastName = "";
			mockObj.Object.Gender = "Male";
			mockObj.Object.Password = "23423";
			mockObj.Object.Login = "ty.mo@gmail.com";

			var mockRepo = new Mock<IBorrowerRepository>();
			var mockService = new Mock<IBorrowerService>();

			// Act
			var result = mockService.Object.Create(mockObj.Object);

			//// Assert 
			Assert.False(result);
		}

		[Fact]
		public void TestPasswordEmptyBorrower()
		{
			//Arrange
			var mockObj = new Mock<Borrower>();
			mockObj.Object.FirstName = "Test";
			mockObj.Object.LastName = "Mo";
			mockObj.Object.Gender = "Male";
			mockObj.Object.Password = "";
			mockObj.Object.Login = "ty.mo@gmail.com";

			var mockRepo = new Mock<IBorrowerRepository>();
			var mockService = new Mock<IBorrowerService>();

			// Act
			var result = mockService.Object.Create(mockObj.Object);

			//// Assert 
			Assert.False(result);
		}
		 
	}
}
