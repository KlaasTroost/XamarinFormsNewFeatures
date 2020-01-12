using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XF4_4Features
{
    public partial class CarouselViewPage : ContentPage
    {
        public CarouselViewPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVMovies.ItemsSource = new MovieService().GetMovieList();
        }
    }
}
