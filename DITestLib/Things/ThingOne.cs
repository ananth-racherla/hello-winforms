using Ninject.Extensions.Logging;

namespace DITestLib.Things
{
    public class ThingOne : IThing
    {
        public ThingOne(ILogger logger)
        {
            logger.Info("I am Thing One");
        }
    }
}