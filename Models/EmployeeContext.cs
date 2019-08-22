using Microsoft.EntityFrameworkCore;

namespace EmployeeRestApi.Models{
    public class EmployeeContext:DbContext{
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options){
        }

        public DbSet<EmployeeItem> EmployeeItems{get;set;}
    }
}