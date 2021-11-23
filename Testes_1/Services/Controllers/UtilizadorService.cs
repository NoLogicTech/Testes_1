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
    public class UtilizadorService:IUtilizadorService
    {
        private readonly HttpClient httpClient;
        
        public UtilizadorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IList<utilizador>> Get()
        {
            var response = await httpClient.GetAsync("api/utilizador");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<utilizador>>(responseContent);
        }
        
        public async Task<utilizador> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<utilizador>($"/api/utilizador/{id}");
        }

        public async Task Put(utilizador element)
        {
            await httpClient.PutAsJsonAsync("/api/utilizador", element);
        }
        
        public async Task Post(utilizador element)
        {
            await httpClient.PostAsJsonAsync("/api/utilizador", element);
        }
        
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"/api/utilizador/{id}");
        }
    }
}