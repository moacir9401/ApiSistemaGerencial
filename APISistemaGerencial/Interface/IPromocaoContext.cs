using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IPromocaoContext
    {
        Task<List<Promocao>> GetAll();
        Task<Promocao> Get<T>(Guid id);
        Task<Promocao> Create(Promocao puncionario);
        Task Update(Promocao puncionario);
        Task Delete(Guid id);

    }
}
