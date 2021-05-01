using Ninject.Extensions.Logging;

namespace DITestLib.RelayModules
{
    public class RelayModuleOne : IRelayModule
    {
        public ILogger Log { get; }

        public RelayModuleOne(ILogger log, bool clearAll = false)
        {
            Log = log;
            Log.Info("I am a RelayModuleOne");
        }
    }
}
