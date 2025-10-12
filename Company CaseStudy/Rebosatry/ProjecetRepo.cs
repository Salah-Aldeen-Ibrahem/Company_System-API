using Company_CaseStudy.Data;
using Company_CaseStudy.Dto.ProjectDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_CaseStudy.Rebosatry
{
    public class ProjecetRepo : GenirecRepo<Project> , IProduct
    {
        public ProjecetRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<Project> DelPro(int id)
        {
            var pro= await _context.Projects.Include(e => e.Empolyees).FirstOrDefaultAsync(i => i.Id == id);
            return pro;
        }

        public async Task<List<ProjectDto>> GetAllPro()
        {
            var pro = await _context.Projects.Include(e => e.Empolyees)
                 .Where(c => c.EndDate >= DateTime.Now).Select(n => new ProjectDto
                 {
                     ProjectName = n.ProjectName,
                     StartDate = n.StartDate,
                     EndDate = n.EndDate,
                     Budget = n.Budget,
                     EmpCounting = n.Empolyees.Count()
                 }).ToListAsync();
            return pro;
        }
    }
}
