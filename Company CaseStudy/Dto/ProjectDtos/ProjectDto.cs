using Company_CaseStudy.Models;
using System.ComponentModel.DataAnnotations;

namespace Company_CaseStudy.Dto.ProjectDtos
{
    public class ProjectDto
    {
        public string ProjectName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Range(1, int.MaxValue)]
        public decimal Budget { get; set; }
        public int EmpCounting { get; set; }
    }
}
