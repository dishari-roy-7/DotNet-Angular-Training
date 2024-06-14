using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication16_Exercise.Models;

namespace WebApplication16_Exercise.Data
{
    public class WebApplication16_ExerciseContext : DbContext
    {
        public WebApplication16_ExerciseContext (DbContextOptions<WebApplication16_ExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication16_Exercise.Models.User> User { get; set; } = default!;
    }
}
