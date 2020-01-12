using System;
using System.Drawing;
using System.Collections.Generic;
namespace XF4_4Features
{
    public class Movie
    {
        public string Title { get; set; }
        public string Cast { get; set; }
        public string ImageUrl { get; set; }
        public Color BgColor { get; set; }
    }

    public class MovieService
    {
        public List<Movie> GetMovieList()
        {
            return new List<Movie>()
                {
                new Movie
                {
                    Title="Jumanji The Next Level",
                    Cast="Kevin Hart, Jack Black",
                    ImageUrl="https://www.filmibeat.com/img/190x100x237/popcorn/movie_posters/jumanjithenextlevel-20191106175407-18923.jpg",
                    BgColor= Color.Red
                },
                new Movie
                {
                    Title="Jumanji The Next Level",
                    Cast="Kevin Hart, Jack Black",
                    ImageUrl="https://www.filmibeat.com/img/190x100x237/popcorn/movie_posters/jumanjithenextlevel-20191106175407-18923.jpg",
                    BgColor= Color.SaddleBrown
                },
                new Movie
                {
                    Title="Jumanji The Next Level",
                    Cast="Kevin Hart, Jack Black",
                    ImageUrl="https://www.filmibeat.com/img/190x100x237/popcorn/movie_posters/jumanjithenextlevel-20191106175407-18923.jpg",
                    BgColor= Color.CadetBlue
                },
                new Movie
                {
                    Title="Jumanji The Next Level",
                    Cast="Kevin Hart, Jack Black",
                    ImageUrl="https://www.filmibeat.com/img/190x100x237/popcorn/movie_posters/jumanjithenextlevel-20191106175407-18923.jpg",
                    BgColor= Color.YellowGreen
                }
            };
        }
    }
}
