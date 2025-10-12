using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company_CaseStudy.Models
{
    [Index (nameof (EmployeeId) , IsUnique = true)]
    public class Contractet
    {
        public int Id { get; set; }
        public string ContractNumber { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Salary { get; set; }
        [ForeignKey ("EmployeeId")]
        public int EmployeeId { get; set; }
        public Empolyee Empolyee { get; set; } = null!;
    }
}
