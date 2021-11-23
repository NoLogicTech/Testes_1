using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Http;

using Testes_1.Services.Controller;
using Testes_1.Services.Interfaces;

namespace Testes_1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            
            builder.Services.AddHttpClient<UtilizadorService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:45000");
            });
            
            builder.Services.AddHttpClient<ClienteService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:45000");
            });

            await builder.Build().RunAsync();
        }
    }
}