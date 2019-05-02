using FasTnT.Host;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

namespace FasTnT.IntegrationTests
{
    [TestClass]
    public class IntegrationTest
    {
        private static TestServer TestServer { get; set; }
        public static HttpClient Client { get; private set; }

        [AssemblyInitialize]
        public static void IntegrationTestInitialize(TestContext context)
        {
            var builder = new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>();
            TestServer = new TestServer(builder);
            Client = TestServer.CreateClient();
        }

        [AssemblyCleanup]
        public static void IntegrationTestCleanup()
        {
            if (Client != null) Client.Dispose();
            if (TestServer != null) TestServer.Dispose();
        }
    }
}
