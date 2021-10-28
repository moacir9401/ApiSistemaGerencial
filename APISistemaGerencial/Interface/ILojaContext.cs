using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface ILojaContext 
    {
        Task<List<Loja>> GetAll();
        Task<Loja> Get<T>(Guid id);
        Task<Loja> Create(Loja loja);
        Task Update(Loja loja);
        Task Delete(Guid id);

    }
}
