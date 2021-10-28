using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IDadosExclusaoContext
    {
        Task<List<DadosExclusao>> GetAll();
        Task<DadosExclusao> Get<T>(Guid id);
        Task<DadosExclusao> Create(DadosExclusao dadosExclusao);
        Task Update(DadosExclusao dadosExclusao);
        Task Delete(Guid id);

    }
}
