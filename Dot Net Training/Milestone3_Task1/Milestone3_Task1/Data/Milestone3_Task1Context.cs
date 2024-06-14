using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone3_Task1.Models;

namespace Milestone3_Task1.Data
{
    public class Milestone3_Task1Context : DbContext
    {
        public Milestone3_Task1Context (DbContextOptions<Milestone3_Task1Context> options)
            : base(options)
        {
        }

        public DbSet<Milestone3_Task1.Models.Task> Task { get; set; } = default!;
    }
}
