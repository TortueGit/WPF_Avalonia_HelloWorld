using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;
using ReactiveUI;
using MyApp.Services;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // public string Greeting => "Hello World!";
        ViewModelBase content;

        public MainWindowViewModel(FakeDatabase db)
        {
            Content = List = new MyFirstNewListViewModel(db.GetItems());
        }

        public ViewModelBase Content
        {
            get => content;
            // RaiseAndSetIfChanged is part of ReactiveUI
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }        

        public MyFirstNewListViewModel List { get; }
        
        public void AddItem()
        {            
            var vm = new AddItemViewModel();
            
            /*
            *   Here, we combine the output of the observables commands results of Ok and Cancel command,
            *   into a single observable stream. As the results are merged into a single stream, we need them to be 
            *   of the same type. To do so, we're selecting a null MyFirstListItem object everytime the Cancel observable
            *   produces a value.
            *   We're taking only the first click on Ok or Cancel button, so we're taking the first value produced by the observable sequence.
            *   Finally, we suscribe of the result of the observable sequence.
            *   If the result is a model (means Ok was clicked), we add it to the list.
            *   Then we set back the Content to the List in order to display the List of items and hide the AddItemView.
            */
            Observable.Merge(
                vm.Ok,
                vm.Cancel.Select(_ => (MyFirstListItemModel)null))
            .Take(1)
            .Subscribe(model =>
            {
                if (model != null)
                {
                    List.Items.Add(model);
                }

                Content = List;
            });

            Content = vm;
        }
    }
}
