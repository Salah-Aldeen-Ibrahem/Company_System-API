using Company_CaseStudy.Dto.EmpolyeesDtos;
using Company_CaseStudy.Models;

namespace Company_CaseStudy.Interface
{
    public interface IEmpolyee : IGenirec<Empolyee>
    {
        Task<List<EmpGetAllDto>> GetSpecific();
        Task<List<EmpolyeeDto>> GetEmpPro();
        Task<Empolyee> GetByPro(int id);

    }
}
