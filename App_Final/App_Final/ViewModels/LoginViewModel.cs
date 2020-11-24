using App_Final.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_Final.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        private string usuario;
        private string senha;
        public Command LoginCommand { get; }

        public string Usuario
        {
            get => usuario;
            set => SetProperty(ref usuario, value);
        }

        public string Senha
        {
            get => senha;
            set => SetProperty(ref senha, value);
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
