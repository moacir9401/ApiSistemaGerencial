using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Interface
{
    public interface DadosExclusaoContext
    {
        private static Dictionary<Guid, Autorizacao> funcionarios = new Dictionary<Guid, Autorizacao>()
        {
            { Guid.Parse("3227a9f0-3a15-4ae1-a016-ca76cc7b043b"), new Autorizacao { Id = Guid.Parse("3227a9f0-3a15-4ae1-a016-ca76cc7b043b"), Descricao = "Fifa 21"}},
            { Guid.Parse("409e5d25-89bf-44cc-988d-1768b63ae4e4"), new Autorizacao { Id = Guid.Parse("409e5d25-89bf-44cc-988d-1768b63ae4e4"), Descricao = "Fifa 20"}},
            { Guid.Parse("cf3175f6-1c51-4311-9dbb-951727e36ca8"), new Autorizacao { Id = Guid.Parse("cf3175f6-1c51-4311-9dbb-951727e36ca8"), Descricao = "Fifa 19"}},
            { Guid.Parse("aed70bc1-852d-4419-82d1-9205109acf75"), new Autorizacao { Id = Guid.Parse("aed70bc1-852d-4419-82d1-9205109acf75"), Descricao = "Fifa 18"}},
            { Guid.Parse("3af0323a-2fed-4d65-844f-d78855e0e516"), new Autorizacao { Id = Guid.Parse("3af0323a-2fed-4d65-844f-d78855e0e516"), Descricao = "Street Fighter V" }},
            { Guid.Parse("2dbba5a9-e5be-4541-9978-a3ce88ace72c"), new Autorizacao { Id = Guid.Parse("2dbba5a9-e5be-4541-9978-a3ce88ace72c"), Descricao = "Grand Theft Auto V"}},
        };
        public Task<List<Autorizacao>> GetAll()
        {
            return Task.FromResult(funcionarios.Values.ToList());
        }

        public Task<Autorizacao> Get(Guid id)
        {
            if (!funcionarios.ContainsKey(id)) return Task.FromResult(new Autorizacao());

            return Task.FromResult(funcionarios[id]);
        }

        public Task<Autorizacao> Create(Autorizacao autorizacao)
        {
            funcionarios.Add(autorizacao.Id, autorizacao);
            return Task.FromResult(autorizacao);

        }

        public Task Update(Autorizacao autorizacao)
        {
            return Task.FromResult(funcionarios[autorizacao.Id] = autorizacao);
        }

        public Task Delete(Guid id)
        {
            return Task.FromResult(funcionarios.Remove(id));
        }

    }
}
