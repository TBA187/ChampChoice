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
    public partial class LandingPage : ContentPage
    {
        private const string Url = "http://www.alphajob.org/api/ClubApi/";
        private ObservableCollection<Club> _club;
        //private NavigationPage MainPage;
        //private string authorizationKey;

        public LandingPage()
        {
            InitializeComponent();

            btnFavourites.Clicked += (s, e) => Navigation.PushModalAsync(new FavouritePage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushModalAsync(new ChampChoicePage());
            btnSettings.Clicked += (s, e) => Navigation.PushModalAsync(new SettingsPage());
        }

        public async void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (TestListView.SelectedItem != null)
            {
                var pageDetail = new PageDetail();
                pageDetail.BindingContext = e.SelectedItem as Club; //Bind selected item to pageDetail as a club object
                TestListView.SelectedItem = null;
                await Navigation.PushModalAsync(pageDetail);
            }
        }

        protected override async void OnAppearing()
        {
            HttpClient client = new HttpClient(); // Initialize new object
            string content = await client.GetStringAsync(Url);
            List<Club> clubs = JsonConvert.DeserializeObject<List<Club>>(content);
            _club = new ObservableCollection<Club>(clubs);
            TestListView.ItemsSource = _club;
            base.OnAppearing();
        }

        private async void OnAdd(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Club club = new Club { clubName = $"New Title: Timestamp {DateTime.UtcNow.Ticks}" };
            string content = JsonConvert.SerializeObject(club);
            await client.PostAsync(Url, new StringContent(content, Encoding.UTF8, "application/json"));
            _club.Insert(0, club);
        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Club club = _club[0];
            club.clubName += " [updated]";
            string content = JsonConvert.SerializeObject(club);
            await client.PutAsync(Url + "/" + club.clubId, new StringContent(content, Encoding.UTF8, "application/json"));
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Club club = _club[0];
            await client.DeleteAsync(Url + "/" + club.clubId);
            _club.Remove(club);
        }
    }
}