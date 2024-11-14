using JobVault.API.Models.RequestModel;
using JobVault.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobVault.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController(ICandidateInfoServices _candidateInfoServices) : ControllerBase
    {
        [HttpPost("StoreInfo")]
        public async Task<IActionResult>StoreCandidateInfo(CandidateInfoRequestModel requestModel)
        {
            return Ok(await _candidateInfoServices.saveCandidateInfo(requestModel));
        }
    }
}
