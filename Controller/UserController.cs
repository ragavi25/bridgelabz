using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using EmployeeManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EmployeeRep employeeReps;
        public UserController(EmployeeRep employeeRep)
        {
            employeeReps = employeeRep;
        }
        ////Get Employee
        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            return employeeReps.GetEmployees();
        }
        [HttpGet("{ID}")]
        public IActionResult GetById(int id)
        {
            if(!employeeReps.TryGetEmployee( id, out var employees ))
            {
                return NotFound();
            }
            return Ok(employees);
        }
        public async Task<IActionResult> CreateAsync([FromBody] Employees employees)
        {
           if(employees.FirstName.Contains("Ragavi"))
            {
                return BadRequest();
            }
            await employeeReps.AddEmployeeAsync(employees);
            return CreatedAtAction(nameof(GetById), new { id = employees.Id },employees);
     
        }
    }
   
}