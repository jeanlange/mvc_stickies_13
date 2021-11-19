using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stickies.Models;

    public class StickyContext : DbContext
    {
        public StickyContext (DbContextOptions<StickyContext> options)
            : base(options)
        {
        }

        public DbSet<Stickies.Models.ScreenSticky> ScreenSticky { get; set; }
    }
