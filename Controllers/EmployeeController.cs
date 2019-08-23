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
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployees(){
            return _context.EmployeeItems.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeItem> GetEmployee(long id){
            var EmployeeItem=_context.EmployeeItems.Find(id);
            if(EmployeeItem==null){
                return NotFound();
            }
            return EmployeeItem;
        }   


        [HttpPut("{id}")]
        public IActionResult PutEmployeeItem(long id,EmployeeItem item){
            EmployeeItem newItem=new EmployeeItem();

            newItem.id=item.id;
            newItem.firstname=item.firstname;
            newItem.lastname=item.lastname;
            newItem.dateofbirth=item.dateofbirth;
            newItem.department=item.department;

            _context.Entry(newItem).State=EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult<EmployeeItem> PostEmployee(EmployeeItem item){
            _context.EmployeeItems.Add(item);
            _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee),new {id=item.id},item);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployeeItem(long id){
            var employeeItem=_context.EmployeeItems.Find(id);

            if(employeeItem==null){
                return NotFound();
            }

            _context.EmployeeItems.Remove(employeeItem);
            _context.SaveChanges();

            return NoContent();
        }
    }
}