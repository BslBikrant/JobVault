using JobVault.API.Models.RequestModel;
using JobVault.Entities;
using JobVault.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobVault.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController(ICandidateInfoServices _candidateInfoServices) : ControllerBase
    {
        [HttpPost("StoreInfo")]
        public async Task<IActionResult>StoreCandidateInfo(CandidateEntities requestModel)
        {
            return Ok(await _candidateInfoServices.saveCandidateInfo(requestModel));
        }
    }
}
