using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using CNProjetos.Client.Models;
using Testes_1.Services.Interfaces;

namespace Testes_1.Services.Controller
{
    public class ClienteService:IClienteService
    {
        private readonly HttpClient httpClient;
        
        public ClienteService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IList<cliente>> Get()
        {
            var response = await httpClient.GetAsync("api/cliente");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<cliente>>(responseContent);
        }
        
        public async Task<cliente> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<cliente>($"/api/cliente/{id}");
        }

        public async Task Put(cliente element)
        {
            await httpClient.PutAsJsonAsync("/api/cliente", element);
        }
        
        public async Task Post(cliente element)
        {
            await httpClient.PostAsJsonAsync("/api/cliente", element);
        }
        
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"/api/cliente/{id}");
        }
    }
}