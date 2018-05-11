using Champ_choice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Champ_choice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent ();

            BindingContext = new ImagesViewModel();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}