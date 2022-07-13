using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VaiVuadoWebApp.Models;

namespace VaiVuadoWebApp.Repository
{
    public class ProductRepository
    {
        HttpClient client = new HttpClient();
        readonly string url = "https://localhost:5001/api/Product";

        public ProductRepository()
        {
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/product");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Product>>(dados);
            }
            return new List<Product>();
        }
    }
}
