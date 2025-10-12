using Company_CaseStudy.Data;
using Company_CaseStudy.Dto.EmpolyeesDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.EntityFrameworkCore;
namespace Company_CaseStudy.Rebosatry
{
    public class EmpolyeeRepo : GenirecRepo<Empolyee>, IEmpolyee
    {
        public EmpolyeeRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Empolyee> GetByPro(int id)
        {
            var er = await _context.Empolyees.Include(p => p.Projects).FirstOrDefaultAsync(i => i.Id == id);
            return er;
        }

        public async Task<List<EmpolyeeDto>> GetEmpPro()
        {
            var emp = await _context.Empolyees.Where(c => c.Contract != null)
                .Select(s => new EmpolyeeDto
                {
                    Name = s.Name,
                    Email = s.Email,
                    Phone = s.Phone,
                    DepId = s.DepId,
                    Counting = s.Projects.Count(),
                })
                .ToListAsync();
            return emp;
        }

        public async Task<List<EmpGetAllDto>> GetSpecific()
        {
            var sp = await _context.Empolyees.Include(d => d.Department)
                .Include(c => c.Contract).Include(p => p.Projects)
                .Select(n => new EmpGetAllDto { 
                     Name = n.Name,
                     Email = n.Email,
                     Phone = n.Phone,
                     DepId = n.DepId,
                     Contract = n.Contract,  
                     Department = n.Department,
                     Projects = n.Projects,

                }).ToListAsync();

            return sp;
        }
        
    }
}
