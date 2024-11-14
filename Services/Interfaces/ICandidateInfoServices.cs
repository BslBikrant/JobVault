using JobVault.API.Models.RequestModel;
using Microsoft.AspNetCore.Mvc;

namespace JobVault.Services.Interfaces
{
    public interface ICandidateInfoServices
    {
        Task<IActionResult>saveCandidateInfo(CandidateInfoRequestModel requestModel);
    }
}
