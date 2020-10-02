using LootLoOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Interface
{
    public interface ITarget
    {
        Task<List<DealsOfTheDayModel>> GetAllOffers(string filterByName = "", string filterByValue = "");
        Task<List<DealsOfTheDayModel>> GetDealsOfTheDay( string filterByName="", string filterByValue="");
        Task<List<OfferCatagory>> GetOfferCatagories();
        Task<FlipkartProducts> GetOfferProducts(string resourceName, string getApi);
        Task<List<FlipkartProducts>> GetAllOfferProducts();
    }
}
