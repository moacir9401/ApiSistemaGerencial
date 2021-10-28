using System;

namespace APISistemaGerencial.Models
{

    public class Loja
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
