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
        private string classificacao;
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
        public string Classificacao
        {
            get => classificacao;
            set => SetProperty(ref classificacao, value);
        }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin, ValidarAutenticacao);
        }
        private async void OnLogin()
        {
            Login novoLogin = new Login()
            {
                Usuario = Usuario,
                Senha = Senha,
                Classificacao = Classificacao
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
