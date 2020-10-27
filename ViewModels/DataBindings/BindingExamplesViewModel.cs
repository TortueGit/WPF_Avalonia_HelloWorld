using System.Reactive;
using ReactiveUI;
using MyApp.Interfaces;

namespace MyApp.ViewModels.DataBindings
{
    public class BindingExamplesViewModel
    {
        string _buttonCaption = "Un boutton !!!";
        public BindingExamplesViewModel()
        {
        }

        public string ButtonCaption => _buttonCaption;
    }
}
