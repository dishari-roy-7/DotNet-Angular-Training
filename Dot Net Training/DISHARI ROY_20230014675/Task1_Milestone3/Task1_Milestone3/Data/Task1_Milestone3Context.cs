using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1_Milestone3.Models;

namespace Task1_Milestone3.Data
{
    public class Task1_Milestone3Context : DbContext
    {
        public Task1_Milestone3Context (DbContextOptions<Task1_Milestone3Context> options)
            : base(options)
        {
        }

        public DbSet<Task1_Milestone3.Models.TaskManagement> TaskManagement { get; set; } = default!;
    }
}
