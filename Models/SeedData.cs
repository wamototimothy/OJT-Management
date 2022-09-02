
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
using OJT_Management.Data;
using System;
    using System.Linq;

    namespace OJT_Management.Models

{
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new OJT_ManagementContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<OJT_ManagementContext>>()))
                {
                    // Look for any movies.
                    if (context.Staff.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Staff.AddRange(
                        new Staff
                        {
                            FirstName = "Timothy",
                            LastName = "Wamoto",
                            Title = "Software Engineer",
                            Email = "wamototimothy@gmail.com"
                            
                        },

                        new Staff 
                        {
                            FirstName = "London",
                            LastName = "Julian",
                            Title = "Software Engineer",
                            Email = "Jl@yahoo.co.uk"

                        },

                        new Staff
                        {
                            FirstName = "Savage",
                            LastName ="Robbie",
                            Title = "Ghostbuster",
                            Email = "RobSav@gmail.com"

                        },

                        new Staff 
                        {
                            FirstName = "Lynnet",
                            LastName = "Nakato",
                            Title = "Business Analyst",
                            Email = "lnakato@hotmail.com"

                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }