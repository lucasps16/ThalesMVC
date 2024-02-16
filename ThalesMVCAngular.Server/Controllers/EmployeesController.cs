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

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
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
        public async Task<IActionResult> GetEmployee(int id)
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

        private int GetYearlySalary(int salary)
        {
            return salary * 12;
        }


    }
}
