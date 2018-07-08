using Avalonia;
using Avalonia.Markup.Xaml;

namespace Airline
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}