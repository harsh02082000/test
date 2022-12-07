using Microsoft.AspNetCore.Mvc;

using RestaurantAPI.Controllers;
using RestaurantBLL.Services;
using RestaurantDAL.Repost;
using RestaurantEntity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using EmployeeController = RestaurantAPI.Controllers.EmployeeController;

namespace RestaurantManagement.Tests.Controller
{
    public class EmployeeControllerTests
    {
        private EmployeeServiceFake _repost;
        
        private EmployeeController _controller;


        public EmployeeControllerTests()
        {
            
            _repost = new EmployeeServiceFake();
       

        }

     
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetEmployees();

            // Assert
            Assert.IsType<List<Employee>>(okResult);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            // Arrange

            Employee employees = new Employee()
            {       EmpId = 1,
                    EmpName = "SDVS",
                    EmpEmail = "XB@XB.com",
                    EmpPassword = "XB",
                    EmpDesignation = "XB",
                    EmpSpeciality = "L1",
                    EmpPhone = 9874563210,
                    EmpGender = 'M',
            };

                // Act
            var createdResponse = _controller.AddEmployee(employees);

            // Assert
            Assert.IsType<OkObjectResult>(createdResponse);
        
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetEmployees();

            // Assert
            var items = Assert.IsType<List<Employee>>(okResult);
            Assert.Equal(0, items.Count);
        }
        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsOkResult()
        {
            // Arrange


            // Act
            var okResult = _controller.GetEmployeeById(1);

            // Assert
            Assert.IsType<Employee>(okResult);
        }
        //[Fact]
        //public void GetEmployees_WhenCalled_ReturnsAllItems()
        //{
        //    // Act
        //    var okResult = _controller.GetEmployees() as OkObjectResult;
        //    // Assert
        //    var items = Assert.IsType<List<Employee>>(okResult.Value);
        //    Assert.Equal(3, items.Count);
        //}
    }
}
