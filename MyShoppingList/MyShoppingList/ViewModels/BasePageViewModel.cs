using Prism.Navigation;
using Prism.Mvvm;

namespace MyShoppingList.ViewModels
{
    public class BasePageViewModel : BindableBase, INavigationAware
    {
        readonly INavigationService _navigationService;
        protected INavigationService NavigationService => _navigationService;

        public BasePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        protected async void NavigateTo<T>() where T 
            : BasePageViewModel { await _navigationService.NavigateAsync<T>(); }
    }
}
