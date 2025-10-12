using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Company_CaseStudy.Models
{
    [Index (nameof(Name) , IsUnique = true)]
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty ;
        public List<Empolyee> Empolyes { get; set; } = null!;
    }
}
