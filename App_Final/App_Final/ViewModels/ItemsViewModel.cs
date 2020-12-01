using App_Final.Models;
using App_Final.Views;
using System;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Essentials;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Final.ViewModels
{
    public class HomeModel : BaseViewModel
    {

       
        public HomeModel()
        {
            Title = "Home";
            AbrirHome = new Command(async () => await Browser.OpenAsync("http://104.41.11.135:1880/ui/"));
        }
        public ICommand AbrirHome { get; }

    }
}