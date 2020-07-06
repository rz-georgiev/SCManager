using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data;
using SCManager.Services;
using System.Net;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class SendGridServiceTests
    {
        private readonly ISendGridService _sendGridService;
        public SendGridServiceTests()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _sendGridService = new SendGridService(configuration);
        }

        [TestMethod]
        public async Task SendEmailAsync_WhenInputIsInvalid_ShouldReturnNull()
        {
            var result = await _sendGridService.SendEmailAsync("", null, "message");
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task SendEmailAsync_WhenAllDataIsCorrect_ShouldReturnAcceptedStatusCode()
        {
            var result = await _sendGridService.SendEmailAsync("scmanager_test@mail.com", "SomeSubject", "SomeMessage");
            Assert.AreEqual(HttpStatusCode.Accepted, result.StatusCode);
        }
    }
}