using Company_CaseStudy.Dto.ContractsDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace Company_CaseStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContract _repo;

        public ContractController(IContract repo)
        {
            _repo = repo;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContracttoEmp(int id)
        {
            var con = await _repo.GetCon(id);
            if (con == null) return NotFound("This Contract is not Found");
            return Ok(con);
        }
        [HttpPost]
        public async Task<IActionResult> AddContract([FromBody] ContractAdddto contractAdddto)
        {
            Contractet contract = new Contractet
            {
                ContractNumber = contractAdddto.ContractNumber,
                StartDate = contractAdddto.StartDate,
                EndDate = contractAdddto.EndDate,
                Salary = contractAdddto.Salary,
                EmployeeId = contractAdddto.EmployeeId,

            };
            await _repo.Add(contract);
            return Created();

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> ConUpd(int id, [FromBody] ContractUpdateDto contractUpdateDto)
        {
            var con = await _repo.Getbyid(id);
            if (con == null) return NotFound("This Contract is not Found");
            con.StartDate = contractUpdateDto.StartDate;
            con.EndDate = contractUpdateDto.EndDate;
            con.Salary = contractUpdateDto.Salary;
            await _repo.Update(con);
            return NoContent();


        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DelCon(int id)
        {
            var Del = await _repo.DelCon(id);
            if (!Del) return NotFound("The Empolyee is still has this contract or the EndDate is bigger than today ");
            await _repo.Delete(id);
            return NoContent(); 
        }

        
    }
}
