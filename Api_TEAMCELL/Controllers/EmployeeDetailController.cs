using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_TEAMCELL.Models;

namespace Api_TEAMCELL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeDetailController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeDetail
        [HttpGet]
        public IEnumerable<EmployeeDetail> GetEmployee()
        {
            return _context.Employee;
        }

        // GET: api/EmployeeDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeDetail = await _context.Employee.FindAsync(id);

            if (employeeDetail == null)
            {
                return NotFound();
            }

            return Ok(employeeDetail);
        }

        // PUT: api/EmployeeDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeDetail([FromRoute] int id, [FromBody] EmployeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeDetail.IdEmployee)
            {
                return BadRequest();
            }

            _context.Entry(employeeDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDetailExists(id))
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

        // POST: api/EmployeeDetail
        [HttpPost]
        public async Task<IActionResult> PostEmployeeDetail([FromBody] EmployeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Employee.Add(employeeDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeDetail", new { id = employeeDetail.IdEmployee }, employeeDetail);
        }

        // DELETE: api/EmployeeDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeDetail = await _context.Employee.FindAsync(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            _context.Employee.Remove(employeeDetail);
            await _context.SaveChangesAsync();

            return Ok(employeeDetail);
        }

        private bool EmployeeDetailExists(int id)
        {
            return _context.Employee.Any(e => e.IdEmployee == id);
        }
    }
}