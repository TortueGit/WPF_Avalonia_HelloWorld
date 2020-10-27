using System.Reactive;
using ReactiveUI;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class AddItemViewModel : ViewModelBase
    {
        string _description;

        public AddItemViewModel()
        {
            /*
            *   this.WhenAnyValue => I think we can use this because the ViewModelBase is a ReactiveObject.
            *   So, here, we are checking if we have value set in our Description textbox. If so, we set the okEnabled to true,
            *   so we can enable the Ok button.
            */
            var okEnabled = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrWhiteSpace(x));

            /*
            *   We create the ReactiveCommand and assign it to our Ok ReactiveCommand.
            *   The ReactiveCommand.Create take 2 arguments, the first is the result of the command,
            *   which is to create a new MyFirstListItemModel with a Description which is the Description we have in the textbox.
            *   The second argument is a bool to evaluate if the command is enabled or not.
            */
            Ok = ReactiveCommand.Create(
                () => new MyFirstListItemModel { Description = Description },
                okEnabled);

            // Creating the Cancel ReactiveCommand, with a simple "execute" lambda doing nothing.
            Cancel = ReactiveCommand.Create(() => { } );

        }
        public string Description
        {
            get => _description;
            // Notify when the Description changed.
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        // Second type of ReactiveCommand is the result of the command.
        // For Ok, the result of the command will be a MyFirstListItemModel object.
        public ReactiveCommand<Unit, MyFirstListItemModel> Ok { get; }
        // For Cancel, the result will be a Unit which is the reactive version of void.
        public ReactiveCommand<Unit, Unit> Cancel { get; }
    }
}
