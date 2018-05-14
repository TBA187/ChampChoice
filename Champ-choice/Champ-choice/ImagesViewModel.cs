using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Champ_choice;

namespace Champ_choice
{
    public class ImagesViewModel
    {
        public ObservableCollection<Image> Images { get; set; }

        public ImagesViewModel()
        {
            Images = new ObservableCollection<Image>
            {
                new Image
                {
                    Name = "hockey.png",
                    Caption = "Hockey",
                    TapClickEventHandler = OnTapped

                },
                new Image
                {
                    Name = "basket.png",
                    Caption = "Basketball",
                    TapClickEventHandler = OnTapped

                },
                    new Image
                {
                    Name = "fodbold.png",
                    Caption = "Fodbold",
                    TapClickEventHandler = OnTapped
                },
                new Image
                {
                    Name = "handbold.png",
                    Caption = "Håndbold",
                    TapClickEventHandler = OnTapped
                },
                new Image
                {
                    Name = "volley.png",
                    Caption = "Volleyball",
                    TapClickEventHandler = OnTapped
                }
            };
        }

        void OnTapped(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new LandingPage());
        }
    }
}