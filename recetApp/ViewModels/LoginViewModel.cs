using System.Windows.Input;
using RecetApp.Views;

namespace RecetApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new Command(async () =>
        {
            // Simula la autenticación
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        });
    }
}
