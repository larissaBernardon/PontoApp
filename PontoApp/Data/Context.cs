#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoApp.Models;

namespace PontoApp
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<PontoApp.Models.Employee> Employee { get; set; }

        public DbSet<PontoApp.Models.Announcements> Announcements { get; set; }
    }
}
