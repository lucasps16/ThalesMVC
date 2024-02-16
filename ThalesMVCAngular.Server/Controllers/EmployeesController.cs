using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThalesMVCAngular.Server.Repositories.Interface;
using ThalesMVCAngular.Server.Models.DTO;

namespace ThalesMVCAngular.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository) // Dependency Injection
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees() //Gets all employees from the repository and returns them as a list of EmployeeDTO
        {
            var employees = await _employeeRepository.GetEmployees();
            var response = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                response.Add(new EmployeeDTO
                {
                    Id = employee.Id,
                    Name = employee.employee_name,
                    Salary = employee.employee_salary,
                    YearlySalary = GetYearlySalary(employee.employee_salary),
                    Age = employee.employee_age
                });
                    
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetEmployee(int id) //Gets a single employee from the repository and returns it as an EmployeeDTO
        {
            var employee = await _employeeRepository.GetEmployee(id);
            var response = new EmployeeDTO
            {
                Id = employee.Id,
                Name = employee.employee_name,
                Salary = employee.employee_salary,
                YearlySalary = GetYearlySalary(employee.employee_salary),
                Age = employee.employee_age
            };
            return Ok(response);
        }

        private int GetYearlySalary(int salary) //Calculates the yearly salary of an employee
        {
            return salary * 12;
        }


    }
}
