using Microsoft.EntityFrameworkCore;

namespace EmployeeMangmentService
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet <Department> Departments { get; set; } //Departments will name of table
        public DbSet<Employee> Employees { get; set; } //Employees will name of table
    }
}
