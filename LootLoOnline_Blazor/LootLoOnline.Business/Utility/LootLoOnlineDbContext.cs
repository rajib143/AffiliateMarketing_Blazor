using System;
using System.Collections.Generic;
using System.Text;
using LootLoOnline.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace LootLoOnline.Business
{
    public class LootLoOnlineDbContext : DbContext
    {
        public IMemoryCache MemoryCache { get; }
        private IConfiguration configuration;

        //public LootLoOnlineDbContext(IConfiguration config, IMemoryCache memoryCache)
        //{
        //    configuration = config;
        //    MemoryCache = memoryCache;
        //}

        //public LootLoOnlineDbContext()
        //{

        //}
        public LootLoOnlineDbContext(DbContextOptions<LootLoOnlineDbContext> options)
       : base(options)
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K9JI0JL; Initial Catalog=LootLoOnlineDatabase; User id=sa;Password=rajib;");
        //    }
        //}

        public DbSet<OfferProduct> OfferProducts { get; set; }
        public DbSet<DealsOfTheDay> DealsOfTheDays { get; set; }
    }
}
