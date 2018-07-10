using System.Collections.Generic;
using System.Reflection;
using Airline.ViewModels;
using Airline.Views;
using Avalonia;
using Avalonia.Controls;
using DryIoc;
using Prism.DryIoc;

namespace Airline.Infrastructure
{
    public class AirlineBootstrapper : DryIocBootstrapper
    {
        private AppBuilder _appBuilder;

        protected override void ConfigureContainer()
        {
            Container.Register<MainWindow>(Reuse.Singleton);
            Container.Register<MainWindowViewModel>();

            base.ConfigureContainer();
        }

        protected override IAvaloniaObject CreateShell()
        {
            _appBuilder = Program.BuildAvaloniaApp();

            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            _appBuilder.Instance.Run(Shell as Window);
        }
    }
}