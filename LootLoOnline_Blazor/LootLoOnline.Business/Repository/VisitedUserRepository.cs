using LootLoOnline.Business.Interface;
using LootLoOnline.Business.Models.DBModel;
using System;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Repository
{
    public class VisitedUserRepository : DataRepository<VisitedUser>, IVisitedUserRepository
    {
        public VisitedUserRepository(LootLoOnlineDbContext lootLoOnlineDbContext) : base(lootLoOnlineDbContext)
        {
        }
        public async Task<int> InsertAvisitor(VisitedUser visitor)
        {
            try
            {
                int isSuccess = 0;
                var result = await Get(x => x.IPAddress == visitor.IPAddress && x.OfferName== visitor.OfferName );

                if (result != null)
                {
                    result.Count = result.Count + 1;
                    isSuccess =await Update(result);
                }
                else
                {
                    Random random = new Random();
                    visitor.Count = random.Next(10, 1000);
                    isSuccess = await Add(visitor);
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
