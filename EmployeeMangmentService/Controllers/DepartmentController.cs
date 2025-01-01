using EmployeeMangmentService.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangmentService.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationDbContext _DBcontext;

        public DepartmentController(ApplicationDbContext context)
        {
            _DBcontext = context;
        }
        // GET Method:
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)] // This is response types
        public async Task<ActionResult<IEnumerable<DEPTDTO>>> GetDepartments()
        {
            return Ok(_DBcontext.Departments);
        }

        // POST: api/departments
        [HttpPost]
        public async Task<ActionResult<DEPTDTO>> CreatetDepartment(DEPTDTO DEPTDTO)
        {

            var existingDepartment = await _DBcontext.Departments.FirstOrDefaultAsync(x => x.Name == DEPTDTO.Name);
            if (existingDepartment != null) 
            {
                ModelState.AddModelError("CustomeError","Department doest exist");
                return BadRequest(ModelState);
            }
            if (DEPTDTO.Id == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Department Model = new()
            {
                Id = DEPTDTO.Id,
                Name = DEPTDTO.Name,
                Location = DEPTDTO.Location
            };
            _DBcontext.Departments.Add(Model);
            _DBcontext.SaveChanges();
            return CreatedAtAction("GetDepartments", new { id = Model.Id }, DEPTDTO);
        }
    }
}
