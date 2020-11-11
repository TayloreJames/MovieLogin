using System;
using Lab21_24.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab21_24.Data.Context
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }
    }
}
