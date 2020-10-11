using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Services
{
    public class MongodbVisitorService
    {
        public IRepository<Visitor> visitorRepository;
        private IConfiguration configuration;
        public IMemoryCache MemoryCache { get; }

        public MongodbVisitorService(IConfiguration config, IMemoryCache memoryCache)
        {
            configuration = config;
            MemoryCache = memoryCache;
            visitorRepository = new MongoDbRepository<Visitor>(configuration, MemoryCache);
        }

        public async Task<bool> InsertAvisitor(Visitor visitor)
        {
            try
            {
                bool isSuccess = false;
                var result = visitorRepository.SearchFor(x => x.IPAddress == visitor.IPAddress && x.dealsOfTheDayModel.title.Contains(visitor.dealsOfTheDayModel.title)
                && x.dealsOfTheDayModel.name.Contains(visitor.dealsOfTheDayModel.name)).FirstOrDefault();

                if (result != null)
                {
                    result.Count = result.Count + 1;
                    isSuccess = visitorRepository.Update(result);
                }
                else
                {
                    Random random = new Random();
                    visitor.Count = random.Next(10, 1000);
                    isSuccess = visitorRepository.Insert(visitor);
                }
                return isSuccess;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
