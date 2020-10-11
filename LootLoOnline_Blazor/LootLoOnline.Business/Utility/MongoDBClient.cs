using MongoDB.Driver;


namespace LootLoOnline.Business
{
    public sealed class MongoDBClient
    {
        private static MongoClient instance = null;
        private static readonly object padlock = new object();
        public static MongoClient Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new MongoClient("mongodb+srv://llo_User:F7U3VkuO170NCwFT@cluster0.8ldl0.azure.mongodb.net/LootLoOnlineDB?retryWrites=true&w=majority");

                        }
                    }
                }
                return instance;
            }
        }
    }
}
