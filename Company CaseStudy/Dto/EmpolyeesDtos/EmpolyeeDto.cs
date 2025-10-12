using Company_CaseStudy.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_CaseStudy.Dto.EmpolyeesDtos
{
    public class EmpolyeeDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [ForeignKey("DepId")]
        public int DepId { get; set; }
        public int Counting { get; set; }
    }
}
