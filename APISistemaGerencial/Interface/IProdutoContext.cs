using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IProdutoContext
    {
        Task<List<Produto>> GetAll();
        Task<Produto> Get<T>(Guid id);
        Task<Produto> Create(Produto produto);
        Task Update(Produto produto);
        Task Delete(Guid id);

    }
}
