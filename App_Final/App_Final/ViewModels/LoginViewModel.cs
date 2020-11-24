using App_Final.Views;
using App_Final.Models;
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
        private bool ValidarAutenticacao()
        {
            return !String.IsNullOrWhiteSpace(usuario)
                && !String.IsNullOrWhiteSpace(senha);
        }
        public string Senha
        {
            get => senha;
            set => SetProperty(ref senha, value);
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin, ValidarAutenticacao);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            
        }
        private async void OnLogin()
        {
            Login novoLogin = new Login()
            {
                Usuario = Usuario,
                Senha = Senha
            };

            if (await DataStore.GetItemAsync(novoLogin.Usuario) != null)
            {
                Console.WriteLine("Encontrou o usuario.");
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
            else
            {
                Console.WriteLine("Não encontrou o usuario.");
            }
        }
    }
}
