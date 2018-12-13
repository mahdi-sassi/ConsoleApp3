using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp3
{
    public static class callAPI
    {
        public static void api()
        {

            const string apiKey = "qh8nmxfu6d52mvkckvsawt62";
            const string Secret = "RdTWcCZ3Vh";

            const string endpoint = "https://api.test.hotelbeds.com/hotel-api/1.0/status";

            // Compute the signature to be used in the API call (combined key + secret + timestamp in seconds)
            string signature;
            using (var sha = SHA256.Create())
            {
                long ts = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
                Console.WriteLine("Timestamp: " + ts);
                var computedHash = sha.ComputeHash(Encoding.UTF8.GetBytes(apiKey + Secret + ts));
                signature = BitConverter.ToString(computedHash).Replace("-", "");
            }

            Console.WriteLine("Signature: " + signature);

            using (var client = new WebClient())
            {
                // Request configuration            
                client.Headers.Add("X-Signature", signature);
                client.Headers.Add("Api-Key", apiKey);
                client.Headers.Add("Accept", "application/xml");
                client.DownloadData(endpoint);
                // Request execution
                string response = client.DownloadString(endpoint);
                Debug.WriteLine(response);
            }
        }
    }
}
