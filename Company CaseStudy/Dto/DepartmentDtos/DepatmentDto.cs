using Company_CaseStudy.Models;

namespace Company_CaseStudy.Dto.DepartmentDtos
{
    public class DepatmentDto
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<Empolyee> Empolyes { get; set; } = null!;
    }
}
