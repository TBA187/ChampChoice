using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Champ_choice.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChampChoicePage : ContentPage
	{
		public ChampChoicePage()
		{
			InitializeComponent ();

            btnHome.Clicked += (s, e) => Navigation.PushAsync(new MainPage());
            btnFavourites.Clicked += (s, e) => Navigation.PushAsync(new FavouritePage());
            btnSettings.Clicked += (s, e) => Navigation.PushAsync(new SettingsPage());
        }
	}
}