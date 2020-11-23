using App_Final.Services;
using App_Final.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Final
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
