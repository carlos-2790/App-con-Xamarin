using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Bienvenidos();
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
