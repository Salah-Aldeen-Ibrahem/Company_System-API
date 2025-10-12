using Company_CaseStudy.Data;
using Company_CaseStudy.Dto.ContractsDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_CaseStudy.Rebosatry
{
    public class ContractRepo : GenirecRepo<Company_CaseStudy.Models.Contractet>, IContract
    {
        public ContractRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> DelCon(int id)
        {
            var del = await _context.Contracts.Include(e => e.Empolyee).ToListAsync();
            if (del.Any(f => f.Empolyee == null || f.EndDate <= DateTime.Now))
            {
                return true;
            }
            return false;

        }

        public async Task<GertConDto> GetCon(int id)
        {
            var con = await _context.Contracts.Include(e => e.Empolyee)
                .Select(n => new GertConDto
                {
                    id = n.Id,
                    ContractNumber = n.ContractNumber,
                    StartDate = n.StartDate,
                    EndDate = n.EndDate,
                    Salary = n.Salary,
                    EmployeeId = n.EmployeeId,
                }).FirstOrDefaultAsync(i => i.id == id);
            return con;
        }

    }
}
