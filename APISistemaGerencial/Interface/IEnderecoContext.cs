using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface IEnderecoContext
    {
        Task<List<Endereco>> GetAll();
        Task<Endereco> Get<T>(Guid id);
        Task<Endereco> Create(Endereco fndereco);
        Task Update(Endereco fndereco);
        Task Delete(Guid id);

    }
}
