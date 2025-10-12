using System.ComponentModel.DataAnnotations;

namespace Company_CaseStudy.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Range(1, int.MaxValue)]
        public decimal Budget { get; set; }
        public List<Empolyee> Empolyees { get; set; } = null!;
    }
}
