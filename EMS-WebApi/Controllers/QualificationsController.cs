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
    public class QualificationsController : ControllerBase
    {
        private readonly ContextDB _context;

        public QualificationsController(ContextDB context)
        {
            _context = context;
        }

        // GET: api/Qualifications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Qualification>>> GetQualification()
        {
          if (_context.Qualification == null)
          {
              return NotFound();
          }
            return await _context.Qualification.ToListAsync();
        }

        // GET: api/Qualifications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Qualification>> GetQualification(int id)
        {
          if (_context.Qualification == null)
          {
              return NotFound();
          }
            var qualification = await _context.Qualification.FindAsync(id);

            if (qualification == null)
            {
                return NotFound();
            }

            return qualification;
        }

        // PUT: api/Qualifications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQualification(int id, Qualification qualification)
        {
            if (id != qualification.Qualification_Id)
            {
                return BadRequest();
            }

            _context.Entry(qualification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QualificationExists(id))
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

        // POST: api/Qualifications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Qualification>> PostQualification(Qualification qualification)
        {
          if (_context.Qualification == null)
          {
              return Problem("Entity set 'ContextDB.Qualification'  is null.");
          }
            _context.Qualification.Add(qualification);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQualification", new { id = qualification.Qualification_Id }, qualification);
        }

        // DELETE: api/Qualifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQualification(int id)
        {
            if (_context.Qualification == null)
            {
                return NotFound();
            }
            var qualification = await _context.Qualification.FindAsync(id);
            if (qualification == null)
            {
                return NotFound();
            }

            _context.Qualification.Remove(qualification);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QualificationExists(int id)
        {
            return (_context.Qualification?.Any(e => e.Qualification_Id == id)).GetValueOrDefault();
        }
    }
}
