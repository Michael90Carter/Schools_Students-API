
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inco_webApi.Models;

namespace Inco_webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly StcharleslwangadbContext _context;

        public SchoolsController(StcharleslwangadbContext context)
        {
            _context = context;
        }

        // GET: api/Schoolsdetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schoolsdetails>>> GetSchoolsdetails()
        {
            if (_context.Schoolsdetails == null)
            {
                return NotFound();
            }
            return await _context.Schoolsdetails.ToListAsync();
        }

        // GET: api/Schoolsdetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Schoolsdetails>> GetSchooldetail(int id)
        {
            if (_context.Schoolsdetails == null)
            {
                return NotFound();
            }
            var schoolsdetails = await _context.Schoolsdetails.FindAsync(id);

            if (schoolsdetails == null)
            {
                return NotFound();
            }

            return schoolsdetails;
        }

        // PUT: api/Schoolsdetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchoolsdetails(int id, Schoolsdetails schoolsdetails)
        {
            if (id != schoolsdetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(schoolsdetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolsdetailExists(id))
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

        // POST: api/Schoolsdetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Schoolsdetails>> PostSchoolstail(Schoolsdetails schoolsdetails)
        {
            if (_context.Schoolsdetails == null)
            {
                return Problem("Entity set 'StcharleslwangadbContext.Schoolsdetails'  is null.");
            }
            _context.Schoolsdetails.Add(schoolsdetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchoolsdetails", new { id = schoolsdetails.Id }, schoolsdetails);
        }

        // DELETE: api/Schoolsdetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchoolsdetails(int id)
        {
            if (_context.Schoolsdetails == null)
            {
                return NotFound();
            }
            var schoolsdetails = await _context.Schoolsdetails.FindAsync(id);
            if (schoolsdetails == null)
            {
                return NotFound();
            }

            _context.Schoolsdetails.Remove(schoolsdetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SchoolsdetailExists(int id)
        {
            return (_context.Schoolsdetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

