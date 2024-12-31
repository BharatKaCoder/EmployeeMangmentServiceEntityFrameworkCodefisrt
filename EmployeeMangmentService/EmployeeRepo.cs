namespace EmployeeMangmentService
{
    public class EmployeeRepo
    {
        public List<Department> GetDepartments()
        {
            var _db = new EmployeeDbContext();
            return _db.Departments.ToList();
        }
    }
}
