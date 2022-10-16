namespace Labb_2___API____Angular__VS_2022.Models
{
    public interface IEmployeeRepository
    {
        void AddNewEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int id);
        void UpdateEmployee(int id, Employee employee);
        void DeleteEmployee(int id);
    }
}
