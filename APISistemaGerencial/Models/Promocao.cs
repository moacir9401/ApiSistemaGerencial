
using System;

namespace APISistemaGerencial.Models
{
    public class Promocao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float? Valor { get; set; }
        public int? Quantidade { get; set; }
    }
}
