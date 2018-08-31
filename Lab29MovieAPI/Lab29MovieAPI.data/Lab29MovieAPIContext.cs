using Lab29MovieAPI.data.Maps;
using Lab29MovieAPI.domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Lab29MovieAPI.data
{
    public class Lab29MovieAPIContext : DbContext
    {
        public Lab29MovieAPIContext() : base("MovieAPI")
        {
            Database.SetInitializer(new Lab29WebAPIInitializer());
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
