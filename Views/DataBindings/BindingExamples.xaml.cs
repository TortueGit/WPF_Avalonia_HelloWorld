using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyApp.Interfaces;
using MyApp.ViewModels.DataBindings;

namespace MyApp.Views.DataBindings
{
    public class BindingExamples : Window, IClosable
    {
        public BindingExamples()
        {
            InitializeComponent();
            DataContext = new BindingExamplesViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
