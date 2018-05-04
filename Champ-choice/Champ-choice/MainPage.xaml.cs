using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Champ_choice.Pages;
using Xamarin.Forms;

namespace Champ_choice
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnFavourites.Clicked += (s, e) => Navigation.PushAsync(new FavouritePage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushAsync(new ChampChoicePage());
            btnSettings.Clicked += (s, e) => Navigation.PushAsync(new SettingsPage());
        }

        

        /* private void OnHomeButtonPressed(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new HomePage());
        } */
    }
}
