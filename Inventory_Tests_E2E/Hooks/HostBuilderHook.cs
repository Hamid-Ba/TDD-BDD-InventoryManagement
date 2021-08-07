using Inventory_Tests_E2E.NetCoreHosting;
using TechTalk.SpecFlow;

namespace Inventory_Tests_E2E.Hooks
{
    [Binding]
    public sealed class HostBuilderHook
    {

        private static readonly DotNetCoreHost _host = new DotNetCoreHost(new DotNetCoreHostOptions()
        {
            Port = HostConstants.Port,
            CsProjectPath = HostConstants.CsProjectPath
        });

        [BeforeFeature("api")]
        public static void BeforeFeature() => _host.Start();


        [AfterFeature("api")]
        public static void AfterFeature() => _host.Stop();

    }
}
