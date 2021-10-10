using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Pelican.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Charity> Charities { get; set; } //added to mirror product one, might need seperate file or something

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Support> Support { get; set; }

    }
}
