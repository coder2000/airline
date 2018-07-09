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

        protected override IAvaloniaObject CreateShell()
        {
            _appBuilder = Program.BuildAvaloniaApp();

            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            _appBuilder.Start(Shell as Window);
        }
    }
}