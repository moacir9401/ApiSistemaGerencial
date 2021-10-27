using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IFuncionarioContext
    {
        Task<List<Funcionario>> GetAll();
        Task<Funcionario> Get(Guid id);
        Task<Funcionario> Create(Funcionario funcionario);
        Task Update(Funcionario funcionario);
        Task Delete(Guid id);

    }
}
