using AppMobileUrban.Services;
using AppMobileUrban.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMobileUrban.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new ItemsViewModel();

        }

        public async void onRegisterProduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroProdutoPage(new requests()));
        }
    }
}