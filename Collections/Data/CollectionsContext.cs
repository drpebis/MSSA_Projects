using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Collections.Models;

namespace Collections.Data
{
    public class CollectionsContext : DbContext
    {
        public CollectionsContext(DbContextOptions<CollectionsContext> options)
    : base(options)
        {
        }

        public DbSet<Collection> Collections { get; set; }
    }
}
