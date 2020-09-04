using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MsMVC.Models;

namespace MsMVC.Data
{
    public class MsMVCContext : DbContext
    {
        public MsMVCContext (DbContextOptions<MsMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MsMVC.Models.Movie> Movie { get; set; }
    }
}
