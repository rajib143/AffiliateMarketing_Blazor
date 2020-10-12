using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LootLoOnline.Business;
using LootLoOnline.Business.Repository;

namespace LootLoOnline.AzureFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {

                LootLoOnlineDbContext lootLoOnlineDbContext = new LootLoOnlineDbContext();
                OfferProductRepository offerProductRepository = new OfferProductRepository(lootLoOnlineDbContext);

                return new OkObjectResult(offerProductRepository.GetAll());
            }
            catch (Exception ex)
            {

                return new BadRequestObjectResult(ex);
            }
        }
    }
}
