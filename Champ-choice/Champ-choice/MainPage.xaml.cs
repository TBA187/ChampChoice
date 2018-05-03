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
        }
        private void OnHomeButtonPressed(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}
