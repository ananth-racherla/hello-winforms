using Ninject.Extensions.Logging;

namespace DITestLib.RelayModules
{
    public class RelayModuleTwo : IRelayModule
    {
        public ILogger Log { get; }

        public RelayModuleTwo(ILogger log, bool clearAll = false)
        {
            Log = log;
            Log.Info("I am RelayModuleTwo");
        }
    }
}
