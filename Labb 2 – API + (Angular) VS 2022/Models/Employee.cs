namespace Labb_2___API____Angular__VS_2022.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public string EmployeeEmail { get; set; }
        public int EmployeePhoneNumber { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCity { get; set; }
        public decimal EmployeeSalary { get; set; }

        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}
