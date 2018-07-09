using System.Composition;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Airline.Views
{
    [Export]
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}