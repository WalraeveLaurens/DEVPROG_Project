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
        private const string _APIKEY = "963581e2ec5b420ad03c9de6c3e3c5c8";
        private const string _USERTOKEN = "49a8870bcb5469d01b0265bc95ef2b49b8a78a11ac3b336033e5b428536daf2d";

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


        public async static Task AddCardAsync(CharacaterCard newCharacter)
        { 
            //thronesapi id == 61bf5dbf0049eb1acc5e92ba
            using (HttpClient client = GetClient())
            {
                
                //string url = $"https://trello.com/1/cards?idList=61bf617f2cb599048581bdde&desc=Name=,&key=963581e2ec5b420ad03c9de6c3e3c5c8&token=49a8870bcb5469d01b0265bc95ef2b49b8a78a11ac3b336033e5b428536daf2d";
                string url = $"https://trello.com/1/cards?idList=61bf617f2cb599048581bdde&key=963581e2ec5b420ad03c9de6c3e3c5c8&token=49a8870bcb5469d01b0265bc95ef2b49b8a78a11ac3b336033e5b428536daf2d";


                string json = JsonConvert.SerializeObject(newCharacter);

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                if(response.IsSuccessStatusCode == false)
                {
                    throw new Exception("Toevoegen van card niet geslaagd");
                }

            }
        }

        

    }
}
