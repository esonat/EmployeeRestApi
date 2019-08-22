using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRestApi.Models;
using System;


namespace EmployeeRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeItem>>> GetEmployees(){
            return await _context.EmployeeItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeItem>> GetEmployee(long id){
            var EmployeeItem=await _context.EmployeeItems.FindAsync(id);
            if(EmployeeItem==null){
                return NotFound();
            }
            return EmployeeItem;
        }   


        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeItem(long id,EmployeeItem item){
            EmployeeItem newItem=new EmployeeItem();

            newItem.id=item.id;
            newItem.firstname=item.firstname;
            newItem.lastname=item.lastname;
            newItem.dateofbirth=item.dateofbirth;
            newItem.department=item.department;

            _context.Entry(newItem).State=EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeItem>> PostEmployee(EmployeeItem item){
             _context.EmployeeItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee),new {id=item.id},item);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeItem(long id){
            var employeeItem=await _context.EmployeeItems.FindAsync(id);

            if(employeeItem==null){
                return NotFound();
            }

            _context.EmployeeItems.Remove(employeeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}