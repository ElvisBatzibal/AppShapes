using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShapes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "Shapes_Experimental"});
            
            MainPage = new NavigationPage ( new MainPage());
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
