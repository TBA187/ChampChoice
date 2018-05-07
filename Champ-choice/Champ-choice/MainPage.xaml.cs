using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Champ_choice.Pages;
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





        /* private void OnHomeButtonPressed(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new HomePage());
        } */
    }
}
