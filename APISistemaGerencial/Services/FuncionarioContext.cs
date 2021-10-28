using APISistemaGerencial.Interface;
using APISistemaGerencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Services
{
    public class FuncionarioContext : IFuncionarioContext
    {
        private static Dictionary<Guid, Funcionario> funcionarios = new Dictionary<Guid, Funcionario>()
        {
            { Guid.Parse("3227a9f0-3a15-4ae1-a016-ca76cc7b043b"), new Funcionario { Id = Guid.Parse("3227a9f0-3a15-4ae1-a016-ca76cc7b043b"), Nome = "Fifa 21"}},
            { Guid.Parse("409e5d25-89bf-44cc-988d-1768b63ae4e4"), new Funcionario { Id = Guid.Parse("409e5d25-89bf-44cc-988d-1768b63ae4e4"), Nome = "Fifa 20"}},
            { Guid.Parse("cf3175f6-1c51-4311-9dbb-951727e36ca8"), new Funcionario { Id = Guid.Parse("cf3175f6-1c51-4311-9dbb-951727e36ca8"), Nome = "Fifa 19"}},
            { Guid.Parse("aed70bc1-852d-4419-82d1-9205109acf75"), new Funcionario { Id = Guid.Parse("aed70bc1-852d-4419-82d1-9205109acf75"), Nome = "Fifa 18"}},
            { Guid.Parse("3af0323a-2fed-4d65-844f-d78855e0e516"), new Funcionario { Id = Guid.Parse("3af0323a-2fed-4d65-844f-d78855e0e516"), Nome = "Street Fighter V" }},
            { Guid.Parse("2dbba5a9-e5be-4541-9978-a3ce88ace72c"), new Funcionario { Id = Guid.Parse("2dbba5a9-e5be-4541-9978-a3ce88ace72c"), Nome = "Grand Theft Auto V"}},
        };
        public Task<List<Funcionario>> GetAll()
        {
            return Task.FromResult(funcionarios.Values.ToList());
        }

        public Task<Funcionario> Get(Guid id)
        {
            if (!funcionarios.ContainsKey(id)) return Task.FromResult(new Funcionario());

                return Task.FromResult(funcionarios[id]);
        }

        public Task<Funcionario> Create(Funcionario funcionario)
        {
            funcionarios.Add(funcionario.Id,funcionario);
            return Task.FromResult(funcionario);
            
        }

        public Task Update(Funcionario funcionario)
        {
            return Task.FromResult(funcionarios[funcionario.Id] = funcionario);
        }
         
        public Task Delete(Guid id)
        {
            return Task.FromResult(funcionarios.Remove(id));
        }


    }
}
