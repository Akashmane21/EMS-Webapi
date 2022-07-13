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
    public class Employee_QualificationController : ControllerBase
    {
        private readonly ContextDB _context;

        public Employee_QualificationController(ContextDB context)
        {
            _context = context;
        }

        // GET: api/Employee_Qualification
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee_Qualification>>> GetEmployee_Qualification()
        {
          if (_context.Employee_Qualification == null)
          {
              return NotFound();
          }
            return await _context.Employee_Qualification.ToListAsync();
        }

        // GET: api/Employee_Qualification/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee_Qualification>> GetEmployee_Qualification(int id)
        {
          if (_context.Employee_Qualification == null)
          {
              return NotFound();
          }
            var employee_Qualification = await _context.Employee_Qualification.FindAsync(id);

            if (employee_Qualification == null)
            {
                return NotFound();
            }

            return employee_Qualification;
        }

        // PUT: api/Employee_Qualification/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee_Qualification(int id, Employee_Qualification employee_Qualification)
        {
            if (id != employee_Qualification.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_Qualification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_QualificationExists(id))
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

        // POST: api/Employee_Qualification
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee_Qualification>> PostEmployee_Qualification(Employee_Qualification employee_Qualification)
        {
          if (_context.Employee_Qualification == null)
          {
              return Problem("Entity set 'ContextDB.Employee_Qualification'  is null.");
          }
            _context.Employee_Qualification.Add(employee_Qualification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee_Qualification", new { id = employee_Qualification.Id }, employee_Qualification);
        }

        // DELETE: api/Employee_Qualification/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee_Qualification(int id)
        {
            if (_context.Employee_Qualification == null)
            {
                return NotFound();
            }
            var employee_Qualification = await _context.Employee_Qualification.FindAsync(id);
            if (employee_Qualification == null)
            {
                return NotFound();
            }

            _context.Employee_Qualification.Remove(employee_Qualification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Employee_QualificationExists(int id)
        {
            return (_context.Employee_Qualification?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
