using MyShoppingList.Enums;
using MyShoppingList.ViewModels;
using System.Collections.Generic;

namespace MyShoppingList.Extensions
{
    static class ViewModelExtensions
    {
        internal static void Add(this IList<ShoppingListViewModel> list, string name, string creator, int numberOfItems, double progress, ListPriority priority)
        {
            list.Add(new ShoppingListViewModel(name, creator, numberOfItems, progress, priority));
        }
    }
}
