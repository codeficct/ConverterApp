using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConverterApp.Vistas;

namespace ConverterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MenuPrincipal());
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
