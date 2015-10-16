﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesModel.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Rating { get; set; }
        public int Rank { get; set; }

    }

    public class MovieDbContext : DbContext
    {
      public  DbSet<Movie> Movies { get; set; }
    }

}
