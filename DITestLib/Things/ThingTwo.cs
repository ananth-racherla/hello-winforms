using Ninject.Extensions.Logging;

namespace DITestLib.Things
{
    public class ThingTwo : IThing
    {
        public ThingTwo(ILogger logger)
        {
            logger.Info("I am Thing Two");
        }
    }
}
