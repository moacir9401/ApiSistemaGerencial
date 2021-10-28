using System;

namespace APISistemaGerencial.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }        
        public string CPF { get; set; }        
        public string DataNascimento { get; set; }        
        public Endereco Endereco { get; set; }        
        public string Observacoes { get; set; }

    }
}
