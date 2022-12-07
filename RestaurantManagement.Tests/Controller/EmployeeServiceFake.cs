using RestaurantBLL.Services;
using RestaurantDAL.Repost;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagement.Tests.Controller
{
    public class EmployeeServiceFake : IEmployeeRepost
    {
        public  List<Employee> employees;
        

        public EmployeeServiceFake()
        {
         employees = new List<Employee>();
            {
                new Employee()
                {
                    EmpId=2,

                    EmpName = "Harsh",
                    EmpEmail = "harsh@gmail.com",
                    EmpPassword = "123",
                    EmpDesignation = "ADMIN",
                    EmpSpeciality = "L1",
                    EmpPhone = 9874563210,
                    EmpGender = 'M',
                };
               
             
            }
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
           

        }

        public void DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return employees.Where(a => a.EmpId == employeeId)
                 .FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
           return employees;
        }

        public Employee Login(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
