using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LootLoOnline.Business.Services
{
  public  class VisitorService
    {
        public IMongoDBRepository<Visitor> visitor;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }
        
        public VisitorService(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            visitor = new MongoDbRepository<Visitor>();
        }


      
    }
}
