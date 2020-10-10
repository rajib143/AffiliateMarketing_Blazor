using LootLoOnline.BatchJob.Utility;
using LootLoOnline.Business.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace LootLoOnline.BatchJob
{
    class Program
    {


        static void  Main(string[] args)
        {
            LogWriter logWriter = new LogWriter("AfiliateAPIConsumeJob");

            Console.WriteLine("Application Started for flipkart bath process");

            IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
            IConfiguration config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", true, true)
              .Build();

            FlipKartMongoDBBatchService flipKartBatchService = new FlipKartMongoDBBatchService(config,cache);

            logWriter.LogWrite(string.Format("Application Started for FlipKart API."));

            flipKartBatchService.RemoveOldOffers().Wait();
            flipKartBatchService.ProcessAllOffers().Wait();
            flipKartBatchService.ProcessOfferProducts().Wait();
            //Task.Run(() =>
            //{
            //    flipKartBatchService.RemoveOldOffers();
            //    flipKartBatchService.ProcessAllOffers();
            //    flipKartBatchService.ProcessOfferProducts();


            //}).Wait();

            logWriter.LogWrite(string.Format("Application ended for FlipKart API."));
            Console.WriteLine("Process End!");
        }
    }
}
