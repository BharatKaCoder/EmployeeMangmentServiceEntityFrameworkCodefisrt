namespace EmployeeMangmentService
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public float Experience { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
