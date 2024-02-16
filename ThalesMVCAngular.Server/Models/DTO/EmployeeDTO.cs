namespace ThalesMVCAngular.Server.Models.DTO
{
    public class EmployeeDTO //This is the model that represents an employee as a Data Transfer Object (DTO)
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int YearlySalary { get; set; }
        public int Age { get; set; }
    }
}
