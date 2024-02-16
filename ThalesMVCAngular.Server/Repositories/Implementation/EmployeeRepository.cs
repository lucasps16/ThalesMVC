using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ThalesMVCAngular.Server.Models.Domain;
using ThalesMVCAngular.Server.Models.DTO;
using ThalesMVCAngular.Server.Repositories.Interface;
namespace ThalesMVCAngular.Server.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeModel>> GetEmployees()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://dummy.restapiexample.com/api/v1/employees");
            var result = await response.Content.ReadAsStringAsync();
            if (result.StartsWith("<"))
            {
                throw new Exception("Too Many Requests, try again later...");
            }
            var employeesObj= JsonConvert.DeserializeObject<JObject>(result)["data"];
            
            List<EmployeeModel> employeeList = JsonConvert.DeserializeObject<List<EmployeeModel>>(employeesObj.ToString());
            return employeeList;
        }

        public async Task<EmployeeModel> GetEmployee(int id)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://dummy.restapiexample.com/api/v1/employee/{id}");
            var result = await response.Content.ReadAsStringAsync();
            if (result.StartsWith("<"))
            {
                throw new Exception("Too Many Requests, try again later...");
            }
            var employeeObj= JsonConvert.DeserializeObject<JObject>(result)["data"];
            EmployeeModel employee = JsonConvert.DeserializeObject<EmployeeModel>(employeeObj.ToString());
            return employee;
        }
    }
}
