using System;
using System.Collections.Generic;
using System.Text;
using Lab21_24.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab21_24.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
    

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(m =>
            {
                m.HasKey(m => m.ID);
                m.HasData(
                    new Movie { ID = 1, Title = "Inception", Genre = Genre.Action, Runtime = TimeSpan.FromMinutes(148) },
                    new Movie { ID = 2, Title = "Kingsman: The Secret Service", Genre = Genre.Action, Runtime = TimeSpan.FromMinutes(129) },
                    new Movie { ID = 3, Title = "Exam", Genre = Genre.Thriller, Runtime = TimeSpan.FromMinutes(101) },
                    new Movie { ID = 4, Title = "Predestination", Genre = Genre.SciFi, Runtime = TimeSpan.FromMinutes(97) },
                    new Movie { ID = 5, Title = "Edge of Tomorrow", Genre = Genre.SciFi, Runtime = TimeSpan.FromMinutes(113) },
                    new Movie { ID = 6, Title = "Looper", Genre = Genre.SciFi, Runtime = TimeSpan.FromMinutes(119) },
                    new Movie { ID = 7, Title = "Akira", Genre = Genre.Animation, Runtime = TimeSpan.FromMinutes(126) },
                    new Movie { ID = 8, Title = "Shrek", Genre = Genre.Family, Runtime = TimeSpan.FromMinutes(95) },
                    new Movie { ID = 9, Title = "Date Night", Genre = Genre.Romance, Runtime = TimeSpan.FromMinutes(102) },
                    new Movie { ID = 10, Title = "Justice League: Doom", Genre = Genre.Animation, Runtime = TimeSpan.FromMinutes(77) });
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
