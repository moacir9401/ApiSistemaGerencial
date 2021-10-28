using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface ILogContext
    {
        Task<List<Log>> GetAll();
        Task<Log> Get<T>(Guid id);
        Task<Log> Create(Log log);
        Task Update(Log log);
        Task Delete(Guid id);

    }
}
