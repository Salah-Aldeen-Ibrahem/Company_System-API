using System.ComponentModel.DataAnnotations.Schema;

namespace Company_CaseStudy.Dto.ContractsDtos
{
    public class ContractAdddto
    {
        public string ContractNumber { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Salary { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
    }
}
