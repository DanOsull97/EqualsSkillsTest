using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EqualsSkillsTest.Data;

namespace EqualsSkillsTest.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        { 
            using (var context = new EqualsSkillsTestContext (serviceProvider.GetRequiredService<DbContextOptions<EqualsSkillsTestContext>>()))
            {
                if (context.Client.Any())
                {
                    return; //DB seeded
                }
                context.Client.Add(
                    new Client
                    {
                        firstName = "Daniel",
                        Surname = "O'Sullivan",
                        phoneNumber = "000000000000000",
                        dateApplied = DateTime.Parse("2021-5-19")

                    }
                    );
                context.SaveChanges();
            }
        }
        }
}
