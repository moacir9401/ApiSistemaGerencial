using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IAutorizacaoContext
    {
        Task<List<Autorizacao>> GetAll<T>();
        Task<Autorizacao> Get<Autorizacao>(Guid id);
        Task<Autorizacao> Create<Autorizacao>(Autorizacao autorizacao);
        Task Update<Autorizacao>(Autorizacao autorizacao);
        Task Delete<Autorizacao>(Guid id);

    }
}
