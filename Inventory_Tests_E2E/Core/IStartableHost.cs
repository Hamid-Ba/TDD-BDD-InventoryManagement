namespace Inventory_Tests_E2E.Core
{
    public interface IStartableHost : IHost
    {
        void Start();
        void Stop();
    }
}