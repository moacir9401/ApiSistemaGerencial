using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public virtual Funcao Funcao { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Loja { get; set; }
    }
}
