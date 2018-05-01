using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Champ_choice.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Champ_choice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavigationView : ContentView
	{
		public NavigationView ()
		{
			InitializeComponent ();

            btnHome.Clicked += (s, e) => Navigation.PushAsync(new HomePage());
        }
	}
}