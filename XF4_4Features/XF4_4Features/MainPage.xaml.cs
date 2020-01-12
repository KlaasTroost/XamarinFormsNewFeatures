using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF4_4Features
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("XF 4.4 SwipeView", "What's new in Xamarin Forms 4.4", "Ok");
        }
    }
}
