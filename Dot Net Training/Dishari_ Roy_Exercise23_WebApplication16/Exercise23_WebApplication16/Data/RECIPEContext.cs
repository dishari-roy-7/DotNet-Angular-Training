using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RECIPE.Models;

namespace RECIPE.Data
{
    public class RECIPEContext : DbContext
    {
        public RECIPEContext (DbContextOptions<RECIPEContext> options)
            : base(options)
        {
        }

        public DbSet<RECIPE.Models.Recipe> Recipe { get; set; } = default!;
    }
}
