using AutoFixture;
using FluentAssertions;
using JobVault.API.Controllers;
using JobVault.API.Models.ResponseModel;
using JobVault.Entities;
using JobVault.Services.Interfaces;
using Moq;
using Xunit;

namespace JobVault.UnitTest
{
    public class CandidatesInfoTest
    {
        private readonly IFixture _fixture;
        private readonly Mock<ICandidateInfoServices> _candidateServiceMock;
        private readonly CandidateController _candidateControllerMock;

        public CandidatesInfoTest()
        {
            _fixture = new Fixture();
            _candidateServiceMock = _fixture.Freeze<Mock<ICandidateInfoServices>>();
            _candidateControllerMock = new CandidateController(_candidateServiceMock.Object);
        }
        [Fact]
        public async Task StoreCandidateInfo_ShouldReturnOkResponse_WhenValidData()
        {
            ///Arrange
            var requestData = _fixture.Create<CandidateEntities>();
            var response = new ResponseModel() { Success=true,Message= "Data Inserted Successfully" };
            _candidateServiceMock.Setup(service => service.saveCandidateInfo(requestData)).ReturnsAsync(response);

            ///Act
            var result=await _candidateControllerMock.StoreCandidateInfo(requestData);

            ///Assert
            result.Should().NotBeNull();
            _candidateServiceMock.Verify(x => x.saveCandidateInfo(requestData), Times.Once());
        }
    }
}
