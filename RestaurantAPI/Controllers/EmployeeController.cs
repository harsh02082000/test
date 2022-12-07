using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBLL.Services;
using RestaurantDAL.Repost;
using RestaurantEntity;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService _employeeService;

        private EmployeeRepost _employeeRepost;

        public EmployeeController(EmployeeRepost employeeRepost)
        {
            _employeeRepost = employeeRepost;
        }


   

  
        [HttpGet("GetEmployees")]//
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepost.GetEmployees(); 
        }



        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int employeeId)
        {
            _employeeRepost.DeleteEmployee(employeeId);
            return Ok("Employee deleted Successfully");
        }

        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _employeeRepost.UpdateEmployee(employee);
            return Ok("Employee Updated Successfully");
        }

        [HttpGet("GetEmployeeById")]
        public Employee GetEmployeeById(int employeeId)
        {
            return _employeeRepost.GetEmployeeById(employeeId);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employeeInfo)
        {
            _employeeRepost.AddEmployee(employeeInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public Employee Login([FromBody] Employee employeeInfo)
        {
            Employee Employee = _employeeRepost.Login(employeeInfo);
            if (Employee != null)
                return Employee;
            else
                return null;
        }
    }
}
