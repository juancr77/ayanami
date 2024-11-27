using recetApp.ViewModels;
using RecetApp.ViewModels;

namespace RecetApp.Views
{
    public partial class FavoriteFoodsPage : ContentPage
    {
        public FavoriteFoodsPage()
        {
            InitializeComponent();
            BindingContext = new FavoriteFoodsViewModel();
        }
    }
}
