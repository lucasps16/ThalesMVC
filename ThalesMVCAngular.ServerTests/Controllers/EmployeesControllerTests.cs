using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThalesMVCAngular.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThalesMVCAngular.Server.Repositories.Interface;
using Moq;
using ThalesMVCAngular.Server.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using ThalesMVCAngular.Server.Models.DTO;
using Xunit;

namespace ThalesMVCAngular.Server.Controllers.Tests
{
    public class EmployeesControllerTests
    {
        [Fact]
        public Task GetEmployeeTest()
        {
            //Arrange
            var mockRepo = new Mock<IEmployeeRepository>();
            var testEmployee = new EmployeeModel
            {
                Id = 1,
                employee_name = "Test Employee",
                employee_salary = 1000,
                employee_age = 30
            };
            mockRepo.Setup(repo => repo.GetEmployee(1)).ReturnsAsync(testEmployee);
            var controller = new EmployeesController(mockRepo.Object);
            //Act
            var result = controller.GetEmployee(1);
            //Assert
            var okResult = result.Result as OkObjectResult;
            var employeeDTO = okResult.Value as EmployeeDTO;
            Xunit.Assert.Equal("Test Employee", employeeDTO.Name);
            Xunit.Assert.Equal(1000, employeeDTO.Salary);
            Xunit.Assert.Equal(12000, employeeDTO.YearlySalary);
            Xunit.Assert.Equal(30, employeeDTO.Age);
            return result;
        }
    }
}