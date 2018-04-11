using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Token
    {
        public string access_token { get; set; }
        public DateTime createDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public long expires_in { get; set; }
        public string token_type { get; set; }


        
        public async Task<string> LoginAsync(string username, string password)
        {
            try
            {
                string Url = "http://localhost:63338/";
                var loginUrl = Url + "token";
                var listKeyValue = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("grant_type", "password")
                };

                var request = new HttpRequestMessage(HttpMethod.Post, loginUrl)
                {
                    Content = new FormUrlEncodedContent(listKeyValue)
                };

                HttpClient httpClient = new HttpClient();
                var response =await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<Token>(await response.Content.ReadAsStringAsync());

                    return result.access_token; 
                }

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
