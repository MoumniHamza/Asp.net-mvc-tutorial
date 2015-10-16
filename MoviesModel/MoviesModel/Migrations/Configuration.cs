namespace MoviesModel.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesModel.Models.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoviesModel.Models.MovieDbContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
     new Movie
     {
         Title = "When Harry Met Sally",
         ReleaseDate = DateTime.Parse("1989-1-11"),
         Genre = "Romantic Comedy",
         Rating = "PG",
         Rank = 2,
         Price = 7.99M
          
     },

      new Movie
      {
          Title = "Ghostbusters ",
          ReleaseDate = DateTime.Parse("1984-3-13"),
          Genre = "Comedy",
          Rating = "PG",
          Rank = 3,
          Price = 8.99M
      },

      new Movie
      {
          Title = "Ghostbusters 2",
          ReleaseDate = DateTime.Parse("1986-2-23"),
          Genre = "Comedy",
          Rating = "PG",
          Rank = 4,
          Price = 9.99M
      },

    new Movie
    {
        Title = "Rio Bravo",
        ReleaseDate = DateTime.Parse("1959-4-15"),
        Genre = "Western",
        Rating = "PG",
        Rank = 5,
        Price = 3.99M
    }
);
        }
    }
}
