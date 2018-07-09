using System.Collections.Generic;
using System.Reflection;
using Airline.Views;
using Avalonia;
using Avalonia.Controls;
using DryIoc;
using DryIoc.MefAttributedModel;
using Prism.DryIoc;

namespace Airline.Infrastructure
{
    public class AirlineBootstrapper : DryIocBootstrapper
    {
        private AppBuilder _appBuilder;

        protected override IContainer CreateContainer()
        {
            return new Container().WithMefAttributedModel();
        }

        protected override void ConfigureContainer()
        {
            Container.RegisterExports(new List<Assembly>{typeof(AirlineBootstrapper).Assembly});

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