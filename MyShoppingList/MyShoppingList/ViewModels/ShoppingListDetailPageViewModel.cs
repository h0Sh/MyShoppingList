using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace MyShoppingList.ViewModels
{
    public class ShoppingListDetailPageViewModel : BasePageViewModel
    {
        public ShoppingListDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
