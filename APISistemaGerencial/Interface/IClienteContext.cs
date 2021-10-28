using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IClienteContext
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente> Get<T>(Guid id);
        Task<Cliente> Create(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(Guid id);

    }
}
