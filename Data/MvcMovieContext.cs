using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        //Entitätenmenge = Tabelle
        //Entität = Zeile

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Entitätsmenge von Movies, quasi Tabelle mit Movies.
        /// </summary>
        public DbSet<Movie> Movie { get; set; }
    }
}
