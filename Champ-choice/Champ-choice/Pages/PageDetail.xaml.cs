using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Champ_choice.Model;
using Champ_choice.Pages;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Champ_choice.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDetail : ContentPage
    {
        public PageDetail()
        {
            InitializeComponent();

            //using (var connection = new MySqlConnection("user id=alphajob_org;" +
            //                 "password=Q1fshaXh0rgxhGj1n7;server=mysql49.unoeuro.com;" +
            //                 "database=alphajob_org_db;" +
            //                 "connection timeout=30"))
            //{
            //    connection.Open();
            //    string sql = "SELECT * FROM Player";
            //    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            //    {
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                //var p = new Player();
            //                hey.Text = reader["playerName"].ToString();
            //                //p.playerNr = (int)reader["playerNr"];
            //                //p.position = reader["position"].ToString();
            //                //listOfPlayers.Add(p);

            //            }
            //        }
            //    }
            //    connection.Close();
            //}
        }

        //protected override void OnAppearing()
        //{
        //    //var listOfPlayers = new List<Player>();


        //    //return listOfPlayers;
        //}
    }
}