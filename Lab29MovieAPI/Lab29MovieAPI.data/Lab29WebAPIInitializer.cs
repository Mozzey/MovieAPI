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
            context.Movies.Add(new Movie()
            {
                MovieId = 4,
                Title = "The_Shawshank_Redemption",
                Category = "Drama",
                Year = "1994"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 5,
                Title = "The_Dark_Knight",
                Category = "Superhero",
                Year = "1998"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 6,
                Title = "Fight_Club",
                Category = "Action",
                Year = "1999"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 7,
                Title = "Forrest_Gump",
                Category = "Comedy",
                Year = "1994"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 8,
                Title = "Goodfellas",
                Category = "Crime",
                Year = "1990"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 9,
                Title = "American_History_X",
                Category = "Drama",
                Year = "1998"
            });
            context.Movies.Add(new Movie()
            {
                MovieId = 10,
                Title = "Back_To_The_Future",
                Category = "Comedy",
                Year = "1985"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
