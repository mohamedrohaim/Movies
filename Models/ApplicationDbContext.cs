﻿using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }

        public DbSet<Movie> Movies { get; set;}
        public DbSet<Genre> Genres { get; set;}

    }
}
