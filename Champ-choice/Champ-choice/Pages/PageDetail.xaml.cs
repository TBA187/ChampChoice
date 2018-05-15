using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Champ_choice.Model;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Champ_choice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetail : ContentPage
    {
        private const string Url = "http://www.alphajob.org/api/PlayerApi/";
        private ObservableCollection<Player> _player;

        public PageDetail()
        {
            InitializeComponent();
        }

        public async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (PlayerListView.SelectedItem != null)
            {
                var playerDetail = new PlayerDetail();
                playerDetail.BindingContext = e.SelectedItem as Player;
                PlayerListView.SelectedItem = null;
                await Navigation.PushModalAsync(playerDetail);
            }
        }

        protected override async void OnAppearing()
        {
            HttpClient client = new HttpClient();
            string content = await client.GetStringAsync(Url);
            List<Player> palyers = JsonConvert.DeserializeObject<List<Player>>(content);
            _player = new ObservableCollection<Player>(palyers);
            PlayerListView.ItemsSource = _player;
            base.OnAppearing();
        }
    }
}