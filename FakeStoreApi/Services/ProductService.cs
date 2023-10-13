using FakeStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FakeStoreApi.Services
{
    internal class ProductService : IProductService
    {
        string URL = "https://api.escuelajs.co/api/v1/products?offset=0&limit=10"; // url de la api

        public async Task<List<Products>> GetAllProducts()
        {
            var httpClient = new HttpClient(); // instancia de httpClient
            var res = await httpClient.GetAsync(URL); // obtener mediante get
            var content = await res.Content.ReadAsStringAsync(); // leer
            var data = JsonSerializer.Deserialize<List<Products>>(content); // parsear 
            return data;
        }
    }
}
