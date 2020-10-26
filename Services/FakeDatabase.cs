using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Services
{
    public class FakeDatabase
    {
        public IEnumerable<MyFirstListItemModel> GetItems() => new[]
        {
            new MyFirstListItemModel { Description = "Walk the dog" },
            new MyFirstListItemModel { Description = "Buy some milk" },
            new MyFirstListItemModel { Description = "Learn Avalonia", IsChecked = true },
        };
    }
}