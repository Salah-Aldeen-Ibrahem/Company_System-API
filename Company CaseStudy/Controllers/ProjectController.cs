using Company_CaseStudy.Dto.ProjectDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company_CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProduct _repo;

        public ProjectController(IProduct repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetallPro()
        {
            var pro = await _repo.GetAllPro();
            return Ok(pro);
        }
        [HttpPost]
        public async Task<IActionResult> AddPro([FromBody]ProjectAddorUpd projectAddorUpd)
        {
            Project pro = new Project
            {
                ProjectName = projectAddorUpd.ProjectName,
                StartDate = projectAddorUpd.StartDate,
                EndDate = projectAddorUpd.EndDate,
                Budget = projectAddorUpd.Budget,
            };
            await _repo.Add(pro);
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdPro(int id , [FromBody] ProjectAddorUpd projectAddorUpd)
        {
            var pro = await _repo.Getbyid(id);
            if(pro == null) return NotFound("There is no Project with this id");
            pro.ProjectName = projectAddorUpd.ProjectName;
            pro.StartDate = projectAddorUpd.StartDate;
            pro.EndDate = projectAddorUpd.EndDate;
            pro.Budget = projectAddorUpd.Budget;
            await _repo.Update(pro);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DelProject(int id)
        {
            var pro = await _repo.DelPro(id);
            if (pro == null) return NotFound("There is no Project with this id");
            if (pro.Empolyees.Any() == true) return BadRequest("You Can't remove the project,There is a empolyee working on it");
            await _repo.Delete(id);
            return NoContent();
         }
    }
}
