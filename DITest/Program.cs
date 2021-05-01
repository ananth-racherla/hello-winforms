using Ninject;
using System;
using System.Windows.Forms;
using Ninject.Extensions.Factory;
using NLog;
using DITestLib.RelayModules;
using DITestLib.Things;

namespace DITest
{
    static class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Logger.Info("DI Test Project Starting");

            using (var kernel = new StandardKernel())
            {
                Logger.Debug("Wiring up the DI Container");

                kernel.Bind<IThing>().To<ThingOne>();

                kernel.Bind<IRelayModule>().To<RelayModuleOne>().Named("moduleone");
                kernel.Bind<IRelayModule>().To<RelayModuleTwo>().Named("moduletwo");
                kernel.Bind<IRelayModuleFactory>().ToFactory(() => new UseFirstArgumentAsNameInstanceProvider());

                var mainForm = kernel.Get<Form1>();
                Application.Run(mainForm);
            }

        }
    }

 
}
