using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpOverrides;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LootLoOnline.Business
{
    public static class Utility
    {
        

        public static DateTime UnixTimeToDateTime(this long unixtime)
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

        public static async Task<string> GetApiResponseAsync(string FkAffiliateId, string FkAffiliateToken, string ApiUrl)
        {
            try
            {
                string fileJsonString = string.Empty;
                var client = new HttpClient();//HttpSingleClient.Instance;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Id", FkAffiliateId);
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Token", FkAffiliateToken);

                var response = await client.GetAsync(ApiUrl);
                response.Headers.TransferEncodingChunked = false;

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

        public static string GetApiResponse(string FkAffiliateId, string FkAffiliateToken, string ApiUrl)
        {
            try
            {
                string fileJsonString = string.Empty;
                var client = new HttpClient();//HttpSingleClient.Instance;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Id", FkAffiliateId);
                client.DefaultRequestHeaders.Add("Fk-Affiliate-Token", FkAffiliateToken);
                var response = client.GetAsync(ApiUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    fileJsonString = response.Content.ReadAsStringAsync().Result;
                }

                return fileJsonString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetIpAddress()
        {
            string IpAddress = string.Empty;
            try
            {
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
                Console.WriteLine(hostName);
                // Get the IP  
                IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                return IpAddress;
            }
            catch (ArgumentNullException Exc)
            {
                return IpAddress;
            }
            catch (InvalidCastException Exc)
            {
                return IpAddress;
            }
            catch (InvalidOperationException Exc)
            {
                return IpAddress;
            }
            catch (NullReferenceException Exc)
            {
                return IpAddress;
            }
            catch (Exception Exc)
            {
                return IpAddress;
            }
        }

        public static string GetMacAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
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
