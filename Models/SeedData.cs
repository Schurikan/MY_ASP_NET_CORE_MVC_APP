using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;
using System.Security.Permissions;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            MovieSeedData(serviceProvider);
            MembershipRequestSeedData(serviceProvider);
        }

        private static void MovieSeedData(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "A"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "B"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "C"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "D"
                    }
                );
                context.SaveChanges();
            }
        }

        private static void MembershipRequestSeedData(IServiceProvider serviceProvider)
        {
            using (var context = new MembershipRequestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MembershipRequestContext>>()))
            {
                // Look for any movies.
                if (context.MembershipRequest.Any())
                {
                    return;   // DB has been seeded
                }

                context.MembershipRequest.AddRange(
                    new MembershipRequest
                    {
                        Forename = "Kevin",
                        Surname = "McLovin",
                        Birthday = new DateTime(2018,10,1),
                        EmailAdress = "test@web.de",
                        PhoneNumber = null
                    },

                    new MembershipRequest
                    {
                        Forename = "Shantal",
                        Surname = "Wolnis",
                        Birthday = new DateTime(2018, 8, 11),
                        EmailAdress = null,
                        PhoneNumber = null
                    }
                );
                context.SaveChanges();
            }
        }
    }
}