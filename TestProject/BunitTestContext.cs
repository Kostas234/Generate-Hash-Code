using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Syncfusion.Blazor;

namespace TestProject
{
    public abstract class BunitTestContext : TestContextWrapper
    {
        [TestInitialize]
        public void Setup() { 
            TestContext = new Bunit.TestContext(); 
            Services.AddSyncfusionBlazor(options => {
                options.IgnoreScriptIsolation = true;
            });
            Services.AddOptions();
        }

        [TestCleanup]
        public void TearDown() => TestContext ? .Dispose();
    }
}
