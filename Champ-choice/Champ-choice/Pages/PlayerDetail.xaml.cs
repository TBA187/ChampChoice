using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Champ_choice.Model;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Champ_choice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerDetail : ContentPage
    {
        public PlayerDetail()
        {
            InitializeComponent();
        }
    }
}