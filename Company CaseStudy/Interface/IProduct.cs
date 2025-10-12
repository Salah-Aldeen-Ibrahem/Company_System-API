using Company_CaseStudy.Dto.ProjectDtos;
using Company_CaseStudy.Models;

namespace Company_CaseStudy.Interface
{
    public interface IProduct : IGenirec<Project>
    {
        Task<List<ProjectDto>> GetAllPro();
        Task <Project> DelPro(int id);
    }
}
