using App_Final.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_Final.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}