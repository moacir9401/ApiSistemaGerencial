using System;

namespace APISistemaGerencial.Models
{
    public class Aviso
    {
        public Guid Id { get; set; }
        public bool Aniversario { get; set; }
        public bool FaltaEstoque { get; set; }
        public int QtdEstoque { get; set; }
    }
}
