using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SendLogin
    {


        public object changeValue(Expression ex )
        {
            

            Type type = typeof(string);
            object x =System.Convert.ChangeType(ex, type);
            return x;
        }




        public async void postAsync(Login login)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63338");
                //client.DefaultRequestHeaders.Add("content-type", "application/json");
                var result = await client.PostAsJsonAsync("/api/Account/Login", login);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
                Console.ReadLine();
            }
        }
        public async Task<string> Register(Login Usr)
        {

            HttpClient client = new HttpClient();

            var url = "http://localhost:63338/api/Account/Login";
            var uri = new Uri(url);

            //-- set up header
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonConvert.SerializeObject(Usr);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(uri, content);
            if (response.IsSuccessStatusCode)
                return response.Content.ToString();
            else
                return null;
            // How to get the HttpStatusCode from the Web Server

        }


        public async Task SendRequestAsync()
        {
            using (var stream = new MemoryStream())
            using (var bson = new BsonWriter(stream))
            {
                var jsonSerializer = new JsonSerializer();

                //var request = new Login
                //{
                //    username = "aaa"
                //   // hashPassword = new byte[] { 2, 5, 7, 10 }
                //};

                //jsonSerializer.Serialize(bson, request);

                var client = new HttpClient
                {
                    BaseAddress = new Uri("http://localhost:63338/api/Account/Login")
                };

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/bson"));

                var byteArrayContent = new ByteArrayContent(stream.ToArray());
                byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue("application/bson");

                var result = await client.PostAsync(
                        "api/Account/Login", byteArrayContent);

                result.EnsureSuccessStatusCode();
            }
        }


    }
}
