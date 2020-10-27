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
