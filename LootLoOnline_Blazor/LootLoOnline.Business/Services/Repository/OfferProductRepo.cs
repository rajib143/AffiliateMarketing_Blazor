using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LootLoOnline.Business.Services.Repository
{
    public class OfferProductRepo
    {
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }
        public IDataRepository<OfferProduct> dataRepository;
        //public OfferProductRepo(IConfiguration config, IMemoryCache memoryCache)
        //{
        //    configuration = config;
        //    MemoryCache = memoryCache;
        //    dataRepository = new DataRepository<OfferProduct>();
        //}

        public OfferProductRepo(LootLoOnlineDbContext lootLoOnlineDbContext)
        {
            dataRepository = new DataRepository<OfferProduct>(lootLoOnlineDbContext);
        }

    }
}
