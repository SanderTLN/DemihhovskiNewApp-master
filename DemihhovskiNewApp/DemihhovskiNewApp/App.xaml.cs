﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemihhovskiNewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SliderStepper();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
