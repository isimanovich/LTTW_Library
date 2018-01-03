using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTTW_Library.Models
{
    public class Genre
    {
        [Required]
        public byte Id { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }

    }
}