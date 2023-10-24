using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Harvir_Pen_Ass_1.Data;
using System;
using System.Linq;

namespace Harvir_Pen_Ass_1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
         
                using (var context = new PenContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<PenContext>>()))
                {
                    // Look for any movies.
                    if (context.Pen.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Pen.AddRange(
                    new Pen
                    {
                        Color = "Blue",
                        Brand = "Bic",
                        Length = 5.5,
                        InkColor = "Black",
                        IsBallpoint = true,
                        Price = 1.99M,
                        Rating = CustomRatingScale.Three
                    },
                    new Pen
                    {
                        Color = "Red",
                        Brand = "Pilot",
                        Length = 5.7,
                        InkColor = "Blue",
                        IsBallpoint = false,
                        Price = 2.49M,
                        Rating = CustomRatingScale.One
                    },
                    new Pen
                    {
                        Color = "Green",
                        Brand = "Paper Mate",
                        Length = 6.0,
                        InkColor = "Green",
                        IsBallpoint = true,
                        Price = 1.79M,
                        Rating = CustomRatingScale.Three
                    },
                    new Pen
                    {
                        Color = "Black",
                        Brand = "Uni-ball",
                        Length = 5.8,
                        InkColor = "Red",
                        IsBallpoint = false,
                        Price = 2.99M,
                        Rating = CustomRatingScale.Two
                    },
                    new Pen
                    {
                        Color = "Purple",
                        Brand = "Sharpie",
                        Length = 5.5,
                        InkColor = "Purple",
                        IsBallpoint = false,
                        Price = 1.49M,
                        Rating = CustomRatingScale.Three
                    },
                    new Pen
                    {
                        Color = "Orange",
                        Brand = "Sakura",
                        Length = 6.2,
                        InkColor = "Orange",
                        IsBallpoint = true,
                        Price = 2.29M,
                        Rating = CustomRatingScale.Four
                    },
                    new Pen
                    {
                        Color = "Pink",
                        Brand = "Zebra",
                        Length = 5.9,
                        InkColor = "Pink",
                        IsBallpoint = false,
                        Price = 1.99M,
                        Rating = CustomRatingScale.Three
                    },
                    new Pen
                    {
                        Color = "Yellow",
                        Brand = "Pentel",
                        Length = 6.1,
                        InkColor = "Yellow",
                        IsBallpoint = true,
                        Price = 2.09M,
                        Rating = CustomRatingScale.One
                    },
                    new Pen
                    {
                        Color = "Brown",
                        Brand = "Faber-Castell",
                        Length = 5.7,
                        InkColor = "Brown",
                        IsBallpoint = false,
                        Price = 2.79M,
                        Rating = CustomRatingScale.Three
                    },
                    new Pen
                    {
                        Color = "Gray",
                        Brand = "Lamy",
                        Length = 6.0,
                        InkColor = "Black",
                        IsBallpoint = true,
                        Price = 3.49M,
                        Rating = CustomRatingScale.Two
                    }
                );

                    context.SaveChanges();
                }
            }
        }
    }
