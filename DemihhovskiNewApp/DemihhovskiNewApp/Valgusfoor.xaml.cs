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
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void on_Clicked(object sender, EventArgs e)
        {
            int c=rnd.Next(1, 4);
            if(c==1)
            {
                pun.BackgroundColor = Color.FromRgb(255, 0, 0);
                kol.BackgroundColor = Color.FromHex("#3F3F00");
                roh.BackgroundColor = Color.FromHex("#004100");
            }
            else if (c == 2)
            {
                kol.BackgroundColor = Color.FromRgb(255, 255, 0);
                pun.BackgroundColor = Color.FromHex("#5A0000");
                roh.BackgroundColor = Color.FromHex("#004100");
            }
            else
            {
                roh.BackgroundColor = Color.FromRgb(0, 255, 0);
                pun.BackgroundColor = Color.FromHex("#5A0000");
                kol.BackgroundColor = Color.FromHex("#3F3F00");
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.FromHex("#5A0000");
            kol.BackgroundColor = Color.FromHex("#3F3F00");
            roh.BackgroundColor = Color.FromHex("#004100");
        }
    }
}