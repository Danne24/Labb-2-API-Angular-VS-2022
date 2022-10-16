using Microsoft.EntityFrameworkCore;

namespace Labb_2___API____Angular__VS_2022.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentID = 1,
                DepartmentName = "IT"
            });

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentID = 2,
                DepartmentName = "HR"
            });

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentID = 3,
                DepartmentName = "Department of Records"
            });

            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentID = 4,
                DepartmentName = "Information Retrieval"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeID = 1,
                EmployeeFirstName = "Paul",
                EmployeeLastName = "Foster",
                EmployeeEmail = "Paul.Foster@Outlook.com",
                EmployeePhoneNumber = 9472917,
                EmployeeGender = "Male",
                EmployeeAddress = "Admiral Street",
                EmployeeCity = "Leeds",
                EmployeeSalary = 22005,
                DepartmentID = 3
            });
        }
    }
}