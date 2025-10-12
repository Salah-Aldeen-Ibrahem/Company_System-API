using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_CaseStudy.Models
{
    public class Empolyee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [ForeignKey ("DepId")]
        public int DepId { get; set; }
        public Department Department { get; set; } = null!;
        public Contractet Contract { get; set; } = null!;
        public List<Project> Projects { get; set; } = null!;
    }
}
