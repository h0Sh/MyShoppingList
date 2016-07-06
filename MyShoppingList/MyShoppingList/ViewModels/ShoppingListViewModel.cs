using MyShoppingList.Enums;
using Prism.Commands;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using Prism.Navigation;

namespace MyShoppingList.ViewModels
{
    public class ShoppingListViewModel
    {
        public string Name { get; private set; }
        public string Creator { get; set; }
        public int NumberOfItems { get; private set; }
        public double Progress { get; private set; }
        public ListPriority Priority { get; private set; }

        public ShoppingListViewModel(string name, string creator, int numberOfItems, double progress, ListPriority priority)
        {
            Name = name;
            Creator = creator;
            NumberOfItems = numberOfItems;
            Progress = progress;
            Priority = priority;
        }

        DelegateCommand _showShoppingListCommand;
        ICommand ShowShoppingListCommand => _showShoppingListCommand ?? (_showShoppingListCommand = new DelegateCommand(DoShowShoppingListAsync));

        async void DoShowShoppingListAsync()
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
    }
}
