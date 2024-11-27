using RecetApp.ViewModels;

namespace RecetApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent(); // Inicializa los componentes definidos en el archivo XAML
            BindingContext = new LoginViewModel();
        }
    }
}
