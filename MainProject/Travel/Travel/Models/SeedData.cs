using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Travel.Data;
using System;
using System.Linq;

namespace Travel.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPlaceContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPlaceContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Place
                    {
                        City = "Москва",
                        Address = "Пр-т Мира, 119",
                        Cost = 0,
                        Rate = 8,
                        Time = null,
                        Status = "Для всей семьи",
                        Type = "Парк",
                        ReviewPlace = "Длинный интересный отзыв",
                        NamePlace = "ВДНХ"
                    },

                    new Place
                    {
                        City = "Москва",
                        Address = "Красная пл.",
                        Cost = 0,
                        Rate = 8,
                        Time = null,
                        Status = "Для всей семьи",
                        Type = "Площадь",
                        ReviewPlace = "Длинный интересный отзыв",
                        NamePlace = "Красная площадь"
                    },

                    new Place
                    {
                        City = "Рязань",
                        Address = "ул. Кремль, 1",
                        Cost = 0,
                        Rate = 4,
                        Time = null,
                        Status = "Для всей семьи",
                        Type = "Площадь",
                        ReviewPlace = "Длинный интересный отзыв",
                        NamePlace = "Рязанский Кремаль"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
