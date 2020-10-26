using System.Collections.Generic;
using System.Collections.ObjectModel;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class MyFirstNewListViewModel : ViewModelBase
    {
        public MyFirstNewListViewModel(IEnumerable<MyFirstListItemModel> items)
        {
            Items = new ObservableCollection<MyFirstListItemModel>(items);
        }

        public ObservableCollection<MyFirstListItemModel> Items { get; }
    }
}