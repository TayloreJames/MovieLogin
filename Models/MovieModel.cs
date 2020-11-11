using System;
using System.ComponentModel.DataAnnotations;

namespace Lab21_24.Models
{
    public class MovieModel
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(20)]
        public string Genre { get; set; }

        public double Runtime { get; set; }

    }
}
