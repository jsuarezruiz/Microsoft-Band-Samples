﻿namespace MicrosoftBand
{
    using ViewModels.Base;
    using Views;
    using System.Diagnostics;
    using Xamarin.Forms;

    public partial class App : Application
    {
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator = _locator ?? new ViewModelLocator();
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ConnectionView());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
        }
    }
}
