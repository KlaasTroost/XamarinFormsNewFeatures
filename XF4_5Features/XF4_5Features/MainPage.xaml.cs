using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace XF4_5Features
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPrefersHomeIndicatorAutoHidden(true);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.None);

           
            
            InitializeComponent();

            VisualStateManager.GoToState(this, "Red");
        }

        void Button1_Clicked(System.Object sender, System.EventArgs e)
        {
            VisualStateManager.GoToState(this, "Red");
            VisualStateManager.GoToState(sender as Button, "Disabled");
        }

        void Button2_Clicked(System.Object sender, System.EventArgs e)
        {
            VisualStateManager.GoToState(this, "Green");
            VisualStateManager.GoToState(sender as Button, "Disabled");
        }

        void Button3_Clicked(System.Object sender, System.EventArgs e)
        {
            VisualStateManager.GoToState(this, "Blue");
            VisualStateManager.GoToState(sender as Button, "Disabled");
        }
    }
}
