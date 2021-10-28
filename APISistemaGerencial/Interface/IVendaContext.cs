using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IVendaContext
    {
        Task<List<Venda>> GetAll();
        Task<Venda> Get<T>(Guid id);
        Task<Venda> Create(Venda venda);
        Task Update(Venda venda);
        Task Delete(Guid id);

    }
}
