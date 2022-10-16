using Microsoft.EntityFrameworkCore;

namespace Labb_2___API____Angular__VS_2022.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }



        public void AddNewEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee employeeToDelete = _context.Employees.FirstOrDefault(e => e.EmployeeID == id);
            _context.Employees.Remove(employeeToDelete);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.Include(e => e.Department).ToList();
        }

        public Employee GetEmployeeByID(int id)
        {
            return _context.Employees.Find(id);
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            var employeeToUpdate = _context.Employees.FirstOrDefault(e => e.EmployeeID == id);



            if (employeeToUpdate != null)
            {
                employeeToUpdate.EmployeeFirstName = employee.EmployeeFirstName;
                employeeToUpdate.EmployeeLastName = employee.EmployeeLastName;
                employeeToUpdate.EmployeeAddress = employee.EmployeeAddress;
                employeeToUpdate.EmployeeCity = employee.EmployeeCity;
                employeeToUpdate.EmployeeEmail = employee.EmployeeEmail;
                employeeToUpdate.EmployeeGender = employee.EmployeeGender;
                employeeToUpdate.EmployeePhoneNumber = employee.EmployeePhoneNumber;
                employeeToUpdate.EmployeeSalary = employee.EmployeeSalary;
                employeeToUpdate.DepartmentID = employee.DepartmentID;
                _context.SaveChanges();
            }
        }
    }
}
