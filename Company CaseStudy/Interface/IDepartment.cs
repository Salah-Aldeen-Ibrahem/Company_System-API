using Company_CaseStudy.Dto.DepartmentDtos;
using Company_CaseStudy.Models;

namespace Company_CaseStudy.Interface
{
    public interface IDepartment :IGenirec<Department>
    {
        Task<List<DepatmentDto>> GetDepwithEmp();
        Task <Department> DelDep(int id);
    }
}
