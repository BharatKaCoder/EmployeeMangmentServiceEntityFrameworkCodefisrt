namespace EmployeeMangmentService.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeDbContext _db;
        public EmployeeAPIController(EmployeeDbContext db)
        {
            _db = db;
        }
    }
}
