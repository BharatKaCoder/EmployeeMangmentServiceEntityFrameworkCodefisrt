using EmployeeMangmentService.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangmentService.Controllers
{
     [Microsoft.AspNetCore.Mvc.Route("api/employee")]
     [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Post method : 
        //[HttpPost]
        //public ActionResult<DEPTDTO> CreateDeparment([FromBody]DEPTDTO dEPTDTO)
        //{
        //    if(_db.Departments.FirstOrDefault(x=>x.Name.ToLower() == DEPTDTO.Name.ToLower()) != null)
        //}
    }
}
