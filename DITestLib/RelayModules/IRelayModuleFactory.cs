namespace DITestLib.RelayModules
{
    public interface IRelayModuleFactory
    {
        IRelayModule Create(string name, bool clearAll = false);
    }
}
