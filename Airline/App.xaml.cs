using Avalonia;
using Avalonia.Markup.Xaml;

namespace Airline
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }
    }
}