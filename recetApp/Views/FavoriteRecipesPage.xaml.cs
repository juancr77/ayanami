using recetApp.ViewModels;
using RecetApp.ViewModels;

namespace RecetApp.Views
{
    public partial class FavoriteRecipesPage : ContentPage
    {
        public FavoriteRecipesPage()
        {
            InitializeComponent();
            BindingContext = new FavoriteRecipesViewModel();
        }
    }
}
