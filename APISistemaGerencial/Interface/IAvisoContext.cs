using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IAvisoContext
    {
        Task<List<Aviso>> GetAll();
        Task<Aviso> Get<Aviso>(Guid id);
        Task<Aviso> Create(Funcionario aviso);
        Task Update(Aviso aviso);
        Task Delete(Guid id);

    }
}
