using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF4_4Features
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[]
                {
                    "SwipeView_Experimental",
                    "CarouselView_Experimental",
                    "IndicatorView_Experimental"
                });

            //TODO
            var navigationPage = new NavigationPage(new MainPage());
            //var navigationPage = new NavigationPage(new CarouselViewPage());
            navigationPage.BarBackgroundColor = Color.Black;
            MainPage = navigationPage;
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
