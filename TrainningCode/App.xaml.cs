using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainningCode
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            NavigationPage navigation = new NavigationPage(new Views.MainPage());
            //MainPage = new Views.HomeView();
            MainPage = navigation;
        }

        //protected override void OnStart()
        //{
        //}

        //protected override void OnSleep()
        //{
        //}

        //protected override void OnResume()
        //{
        //}
    }
}
