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
    public class Employee_DependentController : ControllerBase
    {
        private readonly ContextDB _context;

        public Employee_DependentController(ContextDB context)
        {
            _context = context;
        }

        // GET: api/Employee_Dependent
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee_Dependent>>> GetEmployee_Dependent()
        {
          if (_context.Employee_Dependent == null)
          {
              return NotFound();
          }
            return await _context.Employee_Dependent.ToListAsync();
        }

        // GET: api/Employee_Dependent/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee_Dependent>> GetEmployee_Dependent(int id)
        {
          if (_context.Employee_Dependent == null)
          {
              return NotFound();
          }
            var employee_Dependent = await _context.Employee_Dependent.FindAsync(id);

            if (employee_Dependent == null)
            {
                return NotFound();
            }

            return employee_Dependent;
        }

        // PUT: api/Employee_Dependent/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee_Dependent(int id, Employee_Dependent employee_Dependent)
        {
            if (id != employee_Dependent.Dependent_Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_Dependent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_DependentExists(id))
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

        // POST: api/Employee_Dependent
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee_Dependent>> PostEmployee_Dependent(Employee_Dependent employee_Dependent)
        {
          if (_context.Employee_Dependent == null)
          {
              return Problem("Entity set 'ContextDB.Employee_Dependent'  is null.");
          }
            _context.Employee_Dependent.Add(employee_Dependent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee_Dependent", new { id = employee_Dependent.Dependent_Id }, employee_Dependent);
        }

        // DELETE: api/Employee_Dependent/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee_Dependent(int id)
        {
            if (_context.Employee_Dependent == null)
            {
                return NotFound();
            }
            var employee_Dependent = await _context.Employee_Dependent.FindAsync(id);
            if (employee_Dependent == null)
            {
                return NotFound();
            }

            _context.Employee_Dependent.Remove(employee_Dependent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Employee_DependentExists(int id)
        {
            return (_context.Employee_Dependent?.Any(e => e.Dependent_Id == id)).GetValueOrDefault();
        }
    }
}
