using Company_CaseStudy.Dto.ContractsDtos;
using Microsoft.IdentityModel.Tokens;

namespace Company_CaseStudy.Interface
{
    public interface IContract : IGenirec<Company_CaseStudy.Models.Contractet>
    {
        Task<GertConDto> GetCon(int id);
        Task< bool> DelCon(int id);
    }
}
