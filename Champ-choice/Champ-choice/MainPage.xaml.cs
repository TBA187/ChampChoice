using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Champ_choice.Model;
using Champ_choice.Pages;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Champ_choice
{
	public partial class MainPage : ContentPage
	{
        private const string Url = "http://xam150.azurewebsites.net/api/books/";
        private ObservableCollection<Item> _item;
        private string authorizationKey;

        public MainPage()
		{
			InitializeComponent();

            btnFavourites.Clicked += (s, e) => Navigation.PushAsync(new FavouritePage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushAsync(new ChampChoicePage());
            btnSettings.Clicked += (s, e) => Navigation.PushAsync(new SettingsPage());

            NavigationPage.SetHasNavigationBar(this, false);
        }


        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            if (string.IsNullOrEmpty(authorizationKey))
            {
                authorizationKey = await client.GetStringAsync(Url + "login");
                authorizationKey = JsonConvert.DeserializeObject<string>(authorizationKey);
            }

            client.DefaultRequestHeaders.Add("Authorization", authorizationKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        protected override async void OnAppearing()
        {
            HttpClient client = await GetClient();
            string content = await client.GetStringAsync(Url);
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(content);
            _item = new ObservableCollection<Item>(items);
            TestListView.ItemsSource = _item;
            base.OnAppearing();
        }

        private async void OnAdd(object sender, EventArgs e)
        {
            HttpClient client = await GetClient();
            Item item = new Item { Title = $"New Title: Timestamp {DateTime.UtcNow.Ticks}" };
            string content = JsonConvert.SerializeObject(item);
            await client.PostAsync(Url, new StringContent(content, Encoding.UTF8, "application/json"));
            _item.Insert(0, item);
        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            HttpClient client = await GetClient();
            Item item = _item[0];
            item.Title += " [updated]";
            string content = JsonConvert.SerializeObject(item);
            await client.PutAsync(Url + "/" + item.Id, new StringContent(content, Encoding.UTF8, "application/json"));
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            HttpClient client = await GetClient();
            Item item = _item[0];
            await client.DeleteAsync(Url + "/" + item.Id);
            _item.Remove(item);
        }





        /* private void OnHomeButtonPressed(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new HomePage());
        } */
    }
}
