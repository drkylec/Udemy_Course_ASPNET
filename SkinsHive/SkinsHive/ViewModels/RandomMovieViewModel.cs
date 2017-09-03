using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkinsHive.Models;

namespace SkinsHive.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}