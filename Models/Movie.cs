using System;
using System.ComponentModel.DataAnnotations;

namespace Lab21_24.Models
{
    public enum Genre
    {
        Action, SciFi, Thriller, Horror, Drama, Comedy, Animation, Family, Romance
    }

    public class Movie
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public TimeSpan Runtime { get; set; }

    }
}
