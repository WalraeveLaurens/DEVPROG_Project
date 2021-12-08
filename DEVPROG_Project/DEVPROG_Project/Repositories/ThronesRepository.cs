using DEVPROG_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DEVPROG_Project.Repositories
{
    public static class ThronesRepository
    {
        private static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("accept", "application/json");
            return client;
        }

        public static async Task<List<Character>> GetCharacters()
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    //check url om boards op te vragen en plak key and token op einde van url
                    string url = "https://thronesapi.com/api/v2/Characters";

                    //api callen en het resultaat bijhouden in een variable
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                    {
                        return JsonConvert.DeserializeObject<List<Character>>(json);
                    }
                    return null;

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

    }
}
