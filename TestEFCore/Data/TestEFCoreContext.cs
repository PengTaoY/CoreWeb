using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestEFCore.Models
{
    public class TestEFCoreContext : DbContext
    {
        public TestEFCoreContext (DbContextOptions<TestEFCoreContext> options)
            : base(options)
        {
        }

        public DbSet<TestEFCore.Models.Movie> Movie { get; set; }
    }
}
