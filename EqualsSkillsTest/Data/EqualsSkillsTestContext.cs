using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EqualsSkillsTest.Models;

namespace EqualsSkillsTest.Data
{
    public class EqualsSkillsTestContext : DbContext
    {
        public EqualsSkillsTestContext (DbContextOptions<EqualsSkillsTestContext> options)
            : base(options)
        {
        }

        public DbSet<EqualsSkillsTest.Models.Client> Client { get; set; }
    }
}
