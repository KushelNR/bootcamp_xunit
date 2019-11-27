using System;
using Xunit;
using Moq;
using SimpleWebService.DataAccessLayer;
using SimpleWebService.BusinessLayer;
using SimpleWebService.DataAccessLayer.DTOs;

namespace WebService.Tests
{
    public class WebServiceTests
    {
        private readonly Mock<ICustomerDbService> _dbService;

        public WebServiceTests()
        {
            _dbService = new Mock<ICustomerDbService>();
        }
        [Fact]
        public void CustomerService_GivenUserEmail_ReturnUser()
        {
            //Arrange
            var customerService = new CustomerService(_dbService.Object);
            string email = "john@gmail.com";
            var model = Mock.Of<CustomerModelDTO>(
                x => x.Email == "john@gmail.com" &&
                x.FirstName == "John" &&
                x.LastName == "Doe" &&
                x.Company == "ABC" &&
                x.Age == 35);

            _dbService.Setup(x => x.GetCustomerByEmail(email)).Returns(model);

            //Act
            var result = customerService.GetCustomerByEmail(email);

            Assert.Equal(model.FirstName, result.FirstName);


        }
    }
}
