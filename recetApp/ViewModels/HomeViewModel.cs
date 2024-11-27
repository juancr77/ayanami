using RecetApp.Views;
using System.Windows.Input;

namespace RecetApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateToFavoriteFoodsCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new FavoriteFoodsPage());
        });

        public ICommand NavigateToFavoriteRecipesCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new FavoriteRecipesPage());
        });
    }
}
