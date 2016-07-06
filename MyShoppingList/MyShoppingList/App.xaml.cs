using Prism.Ninject;
using MyShoppingList.Views;

namespace MyShoppingList
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
