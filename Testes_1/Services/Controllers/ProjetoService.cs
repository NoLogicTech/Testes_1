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
    public class ProjetoService:IProjetoService
    {
        private readonly HttpClient httpClient;
        
        public ProjetoService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<IList<projeto>> Get()
        {
            var response = await httpClient.GetAsync("api/projeto");
            response.EnsureSuccessStatusCode();
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<projeto>>(responseContent);
        }
        
        public async Task<projeto> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<projeto>($"/api/projeto/{id}");
        }

        public async Task Put(projeto element)
        {
            await httpClient.PutAsJsonAsync("/api/projeto", element);
        }
        
        public async Task Post(projeto element)
        {
            await httpClient.PostAsJsonAsync("/api/projeto", element);
        }
        
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"/api/projeto/{id}");
        }
    }
}