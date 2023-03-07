using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Menu());
            // Eu salvei Menu na view ent View.Menu
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
