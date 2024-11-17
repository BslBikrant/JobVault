using JobVault.API.Models.ResponseModel;
using JobVault.Entities;

namespace JobVault.Services.Interfaces
{
    public interface ICandidateInfoServices
    {
        Task<ResponseModel> saveCandidateInfo(CandidateEntities requestModel);
    }
}
