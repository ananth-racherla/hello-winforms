using DITestLib.RelayModules;
using DITestLib.Things;
using Ninject.Extensions.Logging;
using System.Windows.Forms;

namespace DITest
{
    // Dependency Injection
    public partial class Form1 : Form
    {

        public Form1(IThing thing, IRelayModuleFactory relayFactory, ILogger logger)
        {
            var relayModule = relayFactory.Create("moduleone", true);

            logger.Debug("Relay Module Created");
            InitializeComponent();
        }
    }
}
