using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using MyShoppingList.Enums;
using MyShoppingList.Extensions;

namespace MyShoppingList.ViewModels
{
    [ImplementPropertyChanged]
    public class MainPageViewModel : BasePageViewModel
    {
        public ObservableCollection<ShoppingListViewModel> ShoppingLists { get; private set; } = new ObservableCollection<ShoppingListViewModel>();

        DelegateCommand _createNewShoppingListCommand;
        private readonly INavigationService _navigationService;

        public ICommand CreateNewShoppingListCommand => _createNewShoppingListCommand ?? (_createNewShoppingListCommand = new DelegateCommand(DoCreateNewShoppingListAsync));

        async void DoCreateNewShoppingListAsync()
        {
            try
            {
                await NavigationService.NavigateAsync<ShoppingListDetailPageViewModel>();
            }
            catch (Exception ex)
            {

            }
        }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            // add dummy data
            ShoppingLists = new ObservableCollection<ShoppingListViewModel>
            {
                { "Weekend groceries", "Alice", 10, 0.3, ListPriority.Urgent },
                { "Beauty", "Bob", 5, 0.1, ListPriority.Normal },
                { "Hardware Store", "Joe", 3, 0.8, ListPriority.Low },
            };
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            //if (parameters.ContainsKey("title"))
            //    Title = (string)parameters["title"] + " and Prism";
        }
    }
}
