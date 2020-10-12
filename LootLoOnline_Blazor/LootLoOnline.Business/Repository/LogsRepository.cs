using LootLoOnline.Business.Interface;
using System.Linq;
using System.Threading.Tasks;
using Log = LootLoOnline.Business.Models.Log;

namespace LootLoOnline.Business.Repository
{
    public class LogsRepository : DataRepository<Log>, ILogsRepository
    {
        public LogsRepository(LootLoOnlineDbContext lootLoOnlineDbContext) : base(lootLoOnlineDbContext)
        {
        }

        public Task<IQueryable<Log>> GetAllLogsAsync()
        {

            return GetAll();
        }
    }

}
