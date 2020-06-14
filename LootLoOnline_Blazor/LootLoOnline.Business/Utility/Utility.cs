using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LootLoOnline.Business
{
    public static class Utility
    {
        public static async Task<DateTime> UnixTimeToDateTime(this long unixtime)
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
       
        public static async Task<string> GetApiResponse(string FkAffiliateId, string FkAffiliateToken, string ApiUrl)
        {
            try
            {
                string fileJsonString = string.Empty;
                var client = HttpSingleClient.Instance;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Id", FkAffiliateId);
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Token", FkAffiliateToken);
                var response = await client.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    fileJsonString = await response.Content.ReadAsStringAsync();
                }

                return fileJsonString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public sealed class HttpSingleClient
    {
        private static HttpClient instance = null;
        private static readonly object padlock = new object();
        public static HttpClient Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new HttpClient();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
