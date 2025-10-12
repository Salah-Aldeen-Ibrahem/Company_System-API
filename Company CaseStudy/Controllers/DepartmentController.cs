using Company_CaseStudy.Dto.DepartmentDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company_CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _repo;
        public DepartmentController(IDepartment repo) { _repo = repo; }
        [HttpGet]
        public async Task<IActionResult> GetDep()
        {
            var dep = await _repo.GetDepwithEmp();
            return Ok(dep);
        }
        [HttpPost]
        public async Task<IActionResult> AddDep([FromBody] DepAddorUpd depAddorUpd)
        {
            Department dep = new Department
            {
                Name = depAddorUpd.Name,
                Location = depAddorUpd.Location,
            };
            await _repo.Add(dep);
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> DepUpd(int id , [FromBody] DepAddorUpd depAddorUpd)
        {
            var dep = await _repo.Getbyid(id);
            if (dep == null) return NotFound("This Department is not found");
            dep.Name = depAddorUpd.Name;
            dep.Location = depAddorUpd.Location;
            await _repo.Update(dep);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DepDel(int id)
        {
            var del = await _repo.DelDep(id);
            if (del == null) return NotFound("This Department is not found");
            if (del.Empolyes.Any() == true) return BadRequest("There is still Empolyee working in this Department");
            await _repo.Delete(id);
            return NoContent();
        }

    }
}
