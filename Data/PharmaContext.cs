using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pharma.Data
{
    public class PharmaContext : DbContext
    {
        public PharmaContext (DbContextOptions<PharmaContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
    }
}
