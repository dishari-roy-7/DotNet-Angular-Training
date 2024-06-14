using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2_Milestone3.Models;

namespace Task2_Milestone3.Data
{
    public class Task2_Milestone3Context : DbContext
    {
        public Task2_Milestone3Context (DbContextOptions<Task2_Milestone3Context> options)
            : base(options)
        {
        }

        public DbSet<Task2_Milestone3.Models.Ticket> Ticket { get; set; } = default!;

        public DbSet<Task2_Milestone3.Models.User> User { get; set; } = default!;
    }
}
