namespace ThalesMVCAngular.Server.Models.Domain
{
    public class EmployeeModel //This is the model that represents an employee
    {
       
        public int Id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int YearlySalary { get; set; }
        public int employee_age { get; set; }

    }
}
