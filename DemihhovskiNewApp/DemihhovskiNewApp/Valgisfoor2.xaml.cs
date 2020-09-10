using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemihhovskiNewApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgisfoor2 : ContentPage
    {
        Label punane, kollane, roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        bool sisse_valja;
        public Valgisfoor2()
        {
            //InitializeComponent();
            punane = new Label()
            {
                Text="Punane",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = 13,
                FontAttributes = FontAttributes.Bold
            };
            pun = new Frame()
            {
                BackgroundColor = Color.FromRgb(255, 0, 0),
                Content = punane,
                Padding = 80,
                CornerRadius = 120,
                Margin = new Thickness(100, 0 ,100 ,0) 
            };
            kollane = new Label()
            {
                Text = "Kollane",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = 13,
                FontAttributes = FontAttributes.Bold
            };
            kol = new Frame()
            {
                BackgroundColor = Color.FromRgb(255, 255, 0),
                Content = kollane,
                Padding = 80,
                CornerRadius = 120,
                Margin = new Thickness(100, 0, 100, 0)
            };
            roheline = new Label()
            {
                Text = "Roheline",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = 13,
                FontAttributes = FontAttributes.Bold
            };
            roh = new Frame()
            {
                BackgroundColor = Color.FromRgb(0, 255, 0),
                Content = roheline,
                Padding = 80,
                CornerRadius = 120,
                Margin = new Thickness(100, 0, 100, 0)
            };
            sisse = new Button()
            {
                Text = "sisse",
                TextColor=Color.Black,
                FontSize = 20,
                BorderColor = Color.Gray,
                BorderWidth = 2,
                BackgroundColor =Color.LightGray,
                Margin = new Thickness(120, 0, 120, 0)
            };
            valja = new Button()
            {
                Text = "valja",
                TextColor = Color.Black,
                FontSize = 20,
                BorderColor = Color.Gray,
                BorderWidth = 2,
                BackgroundColor = Color.LightGray,
                Margin = new Thickness(120, 0, 120, 0)
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh, sisse, valja }
            };
            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked;
            //stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            kol.GestureRecognizers.Add(tap);
            roh.GestureRecognizers.Add(tap);
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr=sender as Frame;
            if (fr == pun & sisse_valja == false) { punane.Text = "Stopp"; }
            else if (fr == kol & sisse_valja == false) { kollane.Text = "Oota"; }
            else if (fr == roh & sisse_valja == false) { roheline.Text = "Mine"; }
            else if (fr == pun & sisse_valja == true) { punane.Text = "Sisse valgusfoor"; }
            else if (fr == kol & sisse_valja == true) { kollane.Text = "Sisse valgusfoor"; }
            else if (fr == roh & sisse_valja == true) { roheline.Text = "Sisse valgusfoor"; }
        }

        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromHex("#5A0000");
            kol.BackgroundColor = Color.FromHex("#3F3F00");
            roh.BackgroundColor = Color.FromHex("#004100");
            punane.Text = "Punane";
            kollane.Text = "Kollane";
            roheline.Text = "Roheline";
            sisse_valja = true;
        }

        private void Sisse_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromRgb(255, 0, 0);
            kol.BackgroundColor = Color.FromRgb(255, 255, 0);
            roh.BackgroundColor = Color.FromRgb(0, 255, 0);
            sisse_valja = false;
        }
    }
}