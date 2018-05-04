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

            btnHome.Clicked += (s, e) => Navigation.PushAsync(new MainPage());
            btnChampChoice.Clicked += (s, e) => Navigation.PushAsync(new ChampChoicePage());
            btnSettings.Clicked += (s, e) => Navigation.PushAsync(new SettingsPage());
        }
	}
}