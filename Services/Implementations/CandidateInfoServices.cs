using JobVault.API.Models.ResponseModel;
using JobVault.Entities;
using JobVault.Services.Interfaces;

namespace JobVault.Services.Implementations
{
    public class CandidateInfoServices(VaultDbContext dbContext) : ICandidateInfoServices
    {
        public async Task<ResponseModel> saveCandidateInfo(CandidateEntities requestModel)
        {
            try
            {
                var result = dbContext.candidates.Where(x => x.Email == requestModel.Email).FirstOrDefault();
                if (result == null)
                {
                    await dbContext.AddAsync(requestModel);
                    await dbContext.SaveChangesAsync();
                    ResponseModel responseModel = new ResponseModel()
                    {
                        Success = true,
                        Message = "Data Inserted Successfully"
                    };
                    return responseModel;
                }
                else
                {
                    result.FirstName = requestModel.FirstName;
                    result.LastName = requestModel.LastName;
                    result.Email = requestModel.Email;
                    result.PhoneNumber = requestModel.PhoneNumber;
                    result.TimeInterval = requestModel.TimeInterval;
                    result.LinkedProfile = requestModel.LinkedProfile;
                    result.GithubProfile = requestModel.GithubProfile;
                    result.Description = requestModel.Description;
                    dbContext.Update(result);
                    await dbContext.SaveChangesAsync();
                    ResponseModel responseModel = new ResponseModel()
                    {
                        Success = true,
                        Message = "Data Updated Successfully"
                    };
                    return responseModel;
                }
            }
            catch (Exception ex)
            {
                ResponseModel responseModel = new ResponseModel()
                {
                    Success = false,
                    Message = ex.Message,
                };
                return responseModel;
            }
        }
    }
}
