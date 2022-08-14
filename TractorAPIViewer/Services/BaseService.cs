using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Data;

namespace TractorAPIViewer.Services
{
    public class BaseService
    {
        /// <summary>
        /// Singleton constructor
        /// </summary>
        public static BaseService Instance { get; } = new BaseService();

        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings()
        {
            Error = (_, __) => { Console.WriteLine("An error occured!"); },
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        HttpClient _client;

        private BaseService()
        {
            _client = new HttpClient();
        }

        public async Task<T> Get<T>(string url)
        {
            try
            {
                Console.WriteLine($"URL: {url}");

                //await Task.Delay(2000);

                HttpResponseMessage response = await _client.GetAsync(url);

                string content = await response.Content.ReadAsStringAsync();

                if(response.IsSuccessStatusCode)
                {
                    Console.WriteLine(content);
                    return JsonConvert.DeserializeObject<T>(content, serializerSettings);
                }
                else
                {
                    throw new Exception("Couldn't load content from URL");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}