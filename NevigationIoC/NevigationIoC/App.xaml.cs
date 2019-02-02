﻿using NevigationIoC.Bootstrapping;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NevigationIoC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LoadTypes();
            // MainPage = new MainPage();
        }

        private void LoadTypes()
        {
            var bootstrapper = new Bootstrapper(this);
            bootstrapper.Run();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
