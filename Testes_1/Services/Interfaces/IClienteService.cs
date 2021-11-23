using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNProjetos.Client.Models;

namespace Testes_1.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IList<cliente>> Get();
        Task<cliente> Get(int id);
        Task Put(cliente request);
        Task Post(cliente request);
        Task Delete(int id);
    }
}