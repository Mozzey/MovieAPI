using Lab29MovieAPI.domain;
using Lab29MovieAPI.domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29MovieAPI.data.Maps
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            HasKey(x => x.MovieId);
            Property(x => x.MovieId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
