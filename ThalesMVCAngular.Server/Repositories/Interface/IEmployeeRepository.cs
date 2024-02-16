using ThalesMVCAngular.Server.Models.Domain;

namespace ThalesMVCAngular.Server.Repositories.Interface
{
    public interface IEmployeeRepository
    {

        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployee(int id);
    }
}
