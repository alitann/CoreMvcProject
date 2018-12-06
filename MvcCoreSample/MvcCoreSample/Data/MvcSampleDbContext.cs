using Microsoft.EntityFrameworkCore;
using MvcCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSample.Data
{
    public class MvcSampleDbContext : DbContext
    {
        public MvcSampleDbContext(DbContextOptions<MvcSampleDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}