using Microsoft.EntityFrameworkCore;

namespace EmployeeMangmentService
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options)
        {

        }
        public DbSet <Department> Departments { get; set; } //Departments will name of table
        public DbSet<Employee> Employees { get; set; } //Employees will name of table

        // After this run the following command.
        // 1. add-migration AddTable_TableName
        // 2. update-database
    }
}
