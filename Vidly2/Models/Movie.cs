﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        public DateTime? DateAdded { get; set; }
        [Required]
        public byte NumberInStocks { get; set; }
        [Required]
        public Genre Genre { get; set; }
    }
}