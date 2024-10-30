using AppMobileUrban.Models;
using AppMobileUrban.Views;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppMobileUrban.ViewModels
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Produtos> _items;
        private string _name;
        private bool _isAdmin;

        private const string Url = "http://10.0.2.2:5152";

        public ObservableCollection<Produtos> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public bool IsAdmin
        {
            get => _isAdmin;
            set
            {
                if (_isAdmin != value)
                {
                    _isAdmin = value;
                    OnPropertyChanged(nameof(IsAdmin));
                }
            }
        }

        public Command CadastrarProdutoCommand { get; }

        public ItemsViewModel()
        {
            Items = new ObservableCollection<Produtos>();
            CadastrarProdutoCommand = new Command(OnCadastrarProduto);
            LoadItems();
            LoadUserSession();
        }

        private async void LoadItems()
        {
            var client = new RestClient(Url);
            var request = new RestRequest("/api/Produtos/GetAllProdutos", Method.Get);
            var response = client.Execute(request);

            var items = JsonConvert.DeserializeObject<List<Produtos>>(response.Content);

            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        private void LoadUserSession()
        {
            if (Application.Current.Properties.ContainsKey("Nome"))
            {
                Name = Application.Current.Properties["Nome"] as string;
            }

            if (Application.Current.Properties.ContainsKey("Administrador"))
            {
                IsAdmin = (bool)Application.Current.Properties["Administrador"];
            }
        }

        private async void OnCadastrarProduto()
        {

            await Shell.Current.GoToAsync("CadastroProdutoPage");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
