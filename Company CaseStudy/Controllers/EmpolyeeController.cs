using Company_CaseStudy.Dto.EmpolyeesDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Company_CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeController : ControllerBase
    {
        private readonly IEmpolyee _repo;

        public EmpolyeeController(IEmpolyee repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmp()
        {
            var emp = await _repo.GetSpecific();
            return Ok(emp);
        }
        [HttpGet("CountingProducts")]
        public async Task<IActionResult> GetAllEmpwithcon()
        {
            var emp = await _repo.GetEmpPro();
            return Ok(emp);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmp([FromBody] EmpAddorUpdateDto empAddorUpdateDto)
        {
            Empolyee emp = new Empolyee
            {
                Name = empAddorUpdateDto.Name,
                Email = empAddorUpdateDto.Email,
                Phone = empAddorUpdateDto.Phone,
                DepId = empAddorUpdateDto.DepId,
            };
            await _repo.Add(emp);
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmp(int id , [FromBody] EmpAddorUpdateDto empAddorUpdateDto)
        {
            var emp = await _repo.Getbyid(id);
            if(emp == null) return NotFound("This Empolyee is not Found");
            emp.Name = empAddorUpdateDto.Name;
            emp.Email = empAddorUpdateDto.Email;
            emp.Phone = empAddorUpdateDto.Phone;
            emp.DepId = empAddorUpdateDto.DepId;
            await _repo.Update(emp);
            return NoContent();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Deleteemp(int id)
        {
            var emp = await _repo.GetByPro(id);
            if (emp == null) return NotFound("This Empolyee is not Found");
            if (emp.Projects.Any() == true) return BadRequest("This Empolyee still didn't finish him Projects"); 
            await _repo.Delete(id);
            return NoContent();
        }
    }
}
