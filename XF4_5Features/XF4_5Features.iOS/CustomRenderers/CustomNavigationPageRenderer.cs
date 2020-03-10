using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF4_5Features.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
namespace XF4_5Features.iOS.CustomRenderers
{
    public class CustomNavigationPageRenderer : NavigationRenderer
    {
        public CustomNavigationPageRenderer()
        {

        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);


        }

    }
}

