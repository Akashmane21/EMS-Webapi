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
    public class Employee_SkillController : ControllerBase
    {
        private readonly ContextDB _context;

        public Employee_SkillController(ContextDB context)
        {
            _context = context;
        }

        // GET: api/Employee_Skill
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee_Skill>>> GetEmployee_Skill()
        {
          if (_context.Employee_Skill == null)
          {
              return NotFound();
          }
            return await _context.Employee_Skill.ToListAsync();
        }

        // GET: api/Employee_Skill/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee_Skill>> GetEmployee_Skill(int id)
        {
          if (_context.Employee_Skill == null)
          {
              return NotFound();
          }
            var employee_Skill = await _context.Employee_Skill.FindAsync(id);

            if (employee_Skill == null)
            {
                return NotFound();
            }

            return employee_Skill;
        }

        // PUT: api/Employee_Skill/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee_Skill(int id, Employee_Skill employee_Skill)
        {
            if (id != employee_Skill.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_Skill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Employee_SkillExists(id))
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

        // POST: api/Employee_Skill
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee_Skill>> PostEmployee_Skill(Employee_Skill employee_Skill)
        {
          if (_context.Employee_Skill == null)
          {
              return Problem("Entity set 'ContextDB.Employee_Skill'  is null.");
          }
            _context.Employee_Skill.Add(employee_Skill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee_Skill", new { id = employee_Skill.Id }, employee_Skill);
        }

        // DELETE: api/Employee_Skill/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee_Skill(int id)
        {
            if (_context.Employee_Skill == null)
            {
                return NotFound();
            }
            var employee_Skill = await _context.Employee_Skill.FindAsync(id);
            if (employee_Skill == null)
            {
                return NotFound();
            }

            _context.Employee_Skill.Remove(employee_Skill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Employee_SkillExists(int id)
        {
            return (_context.Employee_Skill?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
