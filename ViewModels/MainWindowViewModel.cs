using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Services;

namespace MyApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // public string Greeting => "Hello World!";

        public MainWindowViewModel(FakeDatabase db)
        {
            List = new MyFirstNewListViewModel(db.GetItems());
        }

        public MyFirstNewListViewModel List { get; }

    }
}
