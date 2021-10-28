using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IProdutosVendidoContext
    {
        Task<List<ProdutosVendido>> GetAll();
        Task<ProdutosVendido> Get<T>(Guid id);
        Task<ProdutosVendido> Create(ProdutosVendido produtosVendido);
        Task Update(ProdutosVendido produtosVendido);
        Task Delete(Guid id);

    }
}
