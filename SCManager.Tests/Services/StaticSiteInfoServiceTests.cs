using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCManager.Data.Interfaces;
using SCManager.Services;
using System.Net;
using System.Threading.Tasks;

namespace SCManager.Tests.Services
{
    [TestClass]
    public class StaticSiteInfoServiceTests : BaseTest
    {
        private readonly IStaticSiteInfoService _staticSiteInfoService;

        public StaticSiteInfoServiceTests()
        {
            _staticSiteInfoService = new StaticSiteInfoService(SCManagerDbContext);
        }
    }
}