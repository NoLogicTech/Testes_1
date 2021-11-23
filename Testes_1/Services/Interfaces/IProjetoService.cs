using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNProjetos.Client.Models;

namespace Testes_1.Services.Interfaces
{
    public interface IProjetoService
    {
        Task<IList<projeto>> Get();
        Task<projeto> Get(int id);
        Task Put(projeto request);
        Task Post(projeto request);
        Task Delete(int id);
    }
}