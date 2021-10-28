using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IFormaPagamentoContext
    {
        Task<List<FormaPagamento>> GetAll();
        Task<FormaPagamento> Get<T>(Guid id);
        Task<FormaPagamento> Create(FormaPagamento formaPagamento);
        Task Update(FormaPagamento formaPagamentorio);
        Task Delete(Guid id);

    }
}
