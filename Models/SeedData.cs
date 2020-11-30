using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RzAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RzAssignment.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RzAssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RzAssignmentContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movies
                    {
                        Name = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Rating = "8.6",
                        Price = 7.99M,
                        Director = "A",
                        Actor = "A",
                        Actress = "A",
                    },

                    new Movies
                    {
                        Name = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Rating = "8.6",
                        Price = 8.99M,
                        Director = "B",
                        Actor = "B",
                        Actress = "B",
                    },

                    new Movies
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Rating = "8.6",
                        Price = 9.99M,
                        Director = "C",
                        Actor = "C",
                        Actress = "C",
                    },

                    new Movies
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Rating = "Western",
                        Price = 3.99M,
                        Director = "D",
                        Actor = "D",
                        Actress = "D",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
