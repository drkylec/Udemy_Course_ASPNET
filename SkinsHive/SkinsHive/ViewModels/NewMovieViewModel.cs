using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkinsHive.Models;
using System.ComponentModel.DataAnnotations;

namespace SkinsHive.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Movie> Movie { get; set; }
        //public Movie movie { get; set; }
        //public string Title
        //{
        //    get
        //    {
        //        if (movie != null && movie.Id != 0)
        //            return "Edit Movie";

        //        return "New Movie";
        //    }
        //}
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public NewMovieViewModel()
        {
            Id = 0;
        }

        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.DateReleased;
            NumberInStock = (byte)movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}