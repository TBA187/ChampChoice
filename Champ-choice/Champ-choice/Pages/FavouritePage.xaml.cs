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
	public partial class FavouritePage : ContentPage
	{
		public FavouritePage()
		{
			InitializeComponent ();

            btnHome.Clicked += (s, e) => Navigation.PushModalAsync(new LandingPage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushModalAsync(new ChampChoicePage());
            btnSettings.Clicked += (s, e) => Navigation.PushModalAsync(new SettingsPage());

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}