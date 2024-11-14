using JobVault.API.Models.RequestModel;
using JobVault.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobVault.Services.Implementations
{
    public class CandidateInfoServices : ICandidateInfoServices
    {
        public Task<IActionResult> saveCandidateInfo(CandidateInfoRequestModel requestModel)
        {
            throw new NotImplementedException();
        }
    }
}
