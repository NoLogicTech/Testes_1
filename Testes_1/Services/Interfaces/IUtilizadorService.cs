using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNProjetos.Client.Models;

namespace Testes_1.Services.Interfaces
{
    public interface IUtilizadorService
    {
        Task<IList<utilizador>> Get();
        Task<utilizador> Get(int id);
        Task Put(utilizador request);
        Task Post(utilizador request);
        Task Delete(int id);
    }
}