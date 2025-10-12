using Company_CaseStudy.Data;
using Company_CaseStudy.Dto.DepartmentDtos;
using Company_CaseStudy.Interface;
using Company_CaseStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace Company_CaseStudy.Rebosatry
{
    public class DepartmentRepo : GenirecRepo<Department>, IDepartment
    {
        public DepartmentRepo(AppDbContext context) : base(context)
        {
        }

        public async Task <Department> DelDep(int id)
        {
           var del = await _context.Departmentes.Include(e => e.Empolyes).FirstOrDefaultAsync(i => i.Id == id);
            return del;
        }

        public Task<List<DepatmentDto>> GetDepwithEmp()
        {
            var dep = _context.Departmentes.Include(e => e.Empolyes)
                .Select(d => new DepatmentDto {
                    Name = d.Name,
                    Location = d.Location,
                    Empolyes = d.Empolyes,
                }).OrderBy(l => l.Empolyes.Count()).ToListAsync();
            return dep;
        }
    }
}
