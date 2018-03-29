// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.StreetAddresses.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.Cities.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for City entities</summary>
    public class CityDbContext : StreetAddressDbContext
    {
        /// <summary>Constructs CityDbContext EntityFrameworkCore database context using given options</summary>
        public CityDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of City entities</summary>
        public DbSet<City> Cities { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasIndex(new City().GetUniqueIndex()).IsUnique();
        }
    }
}
