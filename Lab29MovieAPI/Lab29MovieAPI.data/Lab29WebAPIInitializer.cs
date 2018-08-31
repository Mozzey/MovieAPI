using Lab29MovieAPI.domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29MovieAPI.data
{
    public class Lab29WebAPIInitializer : DropCreateDatabaseAlways<Lab29MovieAPIContext>
    {
        protected override void Seed(Lab29MovieAPIContext context)
        {
            context.Movies.Add(new Movie()
            {
                MovieId = 1,
                Title = "Dazed_and_Confused",
                Category = "Comedy",
                Year = "1993"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 2,
                Title = "Hackers",
                Category = "Great Bad Movie",
                Year = "1995"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 3,
                Title = "The_Mighty_Ducks",
                Category = "Drama",
                Year = "1992"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
