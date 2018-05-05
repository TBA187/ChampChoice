using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Champ_choice.Pages;
using Xamarin.Forms;

namespace Champ_choice
{
	public partial class App : Application
	{
        //public static NavigationPage Navigation = null;
        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage (new MainPage());

            //Application.Current.MainPage = Navigation;

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

    }
}
