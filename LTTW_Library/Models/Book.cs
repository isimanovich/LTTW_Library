using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTTW_Library.Models
{
    public class Book
    {
        public string Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(255)]
        public string Author { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        [StringLength(255)]
        public string Isbn { get; set; }
        [Required]
        [StringLength(255)]
        public string Publisher { get; set; }
        [Required]
        public int Stock { get; set; }
    }

}