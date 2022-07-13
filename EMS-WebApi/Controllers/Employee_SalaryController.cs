using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EMS_WebApi.Model;

namespace EMS_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_SalaryController : ControllerBase
    {
        private readonly ContextDB _context;

        public Employee_SalaryController(ContextDB context)
        {
            _context = context;
        }

        // GET: api/Employee_Salary
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee_Salary>>> GetEmployee_Salary()
        {
          if (_context.Employee_Salary == null)
          {
              return NotFound();
          }
            return await _context.Employee_Salary.ToListAsync();
        }

        // GET: api/Employee_Salary/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee_Salary>> GetEmployee_Salary(int id)
        {
          if (_context.Employee_Salary == null)
          {
              return NotFound();
          }
            var employee_Salary = await _context.Employee_Salary.FindAsync(id);

            if (employee_Salary == null)
            {
                return NotFound();
            }

            return employee_Salary;
        }

        // PUT: api/Employee_Salary/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee_Salary(int id, Employee_Salary employee_Salary)
        {
            if (id != employee_Salary.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_Salary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_SalaryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employee_Salary
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee_Salary>> PostEmployee_Salary(Employee_Salary employee_Salary)
        {
          if (_context.Employee_Salary == null)
          {
              return Problem("Entity set 'ContextDB.Employee_Salary'  is null.");
          }
            _context.Employee_Salary.Add(employee_Salary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee_Salary", new { id = employee_Salary.Id }, employee_Salary);
        }

        // DELETE: api/Employee_Salary/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee_Salary(int id)
        {
            if (_context.Employee_Salary == null)
            {
                return NotFound();
            }
            var employee_Salary = await _context.Employee_Salary.FindAsync(id);
            if (employee_Salary == null)
            {
                return NotFound();
            }

            _context.Employee_Salary.Remove(employee_Salary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Employee_SalaryExists(int id)
        {
            return (_context.Employee_Salary?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
