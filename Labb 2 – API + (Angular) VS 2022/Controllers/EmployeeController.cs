using Labb_2___API____Angular__VS_2022.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb_2___API____Angular__VS_2022.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employee;

        public EmployeeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }



        // Get all employees
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employee.GetAllEmployees();
            return Ok(employees);
        }

        // Get single employee 
        [HttpGet]
        [Route("id")]
        [ActionName("GetSingleEmployee")]
        public IActionResult GetSingleEmployee(int id)
        {
            var employee = _employee.GetEmployeeByID(id);
            return Ok(employee);
        }

        // Create a new employee
        [HttpPost]
        public IActionResult CreateNewEmployee(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            _employee.AddNewEmployee(employee);
            return CreatedAtAction(nameof(GetSingleEmployee), new { id = employee.EmployeeID }, employee);
        }

        // Update employee
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            if (id != 0)
            {
                _employee.UpdateEmployee(id, employee);
                return Ok(employee);
            }

            return NotFound("The employee was not found!");
        }

        // Delete employee
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id != 0)
            {
                _employee.DeleteEmployee(id);
                return Ok();
            }

            return NotFound($"An employee with the id {id} was not found!");
        }
    }
}
