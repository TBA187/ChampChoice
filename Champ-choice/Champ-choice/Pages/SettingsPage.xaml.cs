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
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();

            btnFavourites.Clicked += (s, e) => Navigation.PushModalAsync(new FavouritePage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushModalAsync(new ChampChoicePage());
            btnHome.Clicked += (s, e) => Navigation.PushModalAsync(new LandingPage());

            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}