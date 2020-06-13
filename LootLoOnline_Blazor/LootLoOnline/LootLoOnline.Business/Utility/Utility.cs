using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LootLoOnline.Business.Utility
{
    public class Utility
    {
        public static async Task<DateTime> UnixTimeToDateTime(long unixtime)
        {
            try
            {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddMilliseconds(unixtime).ToLocalTime();
                return dtDateTime;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
