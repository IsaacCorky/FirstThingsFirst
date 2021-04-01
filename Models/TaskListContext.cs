using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Models
{
    public class TaskListContext : DbContext
    {
        public TaskListContext (DbContextOptions<TaskListContext> options) : base (options)
        { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
