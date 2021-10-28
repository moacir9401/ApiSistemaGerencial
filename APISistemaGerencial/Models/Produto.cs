using System;

namespace APISistemaGerencial.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string CodigoBarra { get; set; }
        public string Nome { get; set; }
        public float? ValorEntrada { get; set; }
        public float? ValorSaida { get; set; }
        public int? Quantidade { get; set; }
        public int? TempoGarantia { get; set; }
        public bool Servico { get; set; }
        public string Loja { get; set; }
    }
}
