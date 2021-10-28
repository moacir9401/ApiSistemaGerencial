using System;

namespace APISistemaGerencial.Models
{
    public class ProdutosVendido
    {
        public Guid Id { get; set; }
        public Produto Produto { get; set; }
        public string IdVenda { get; set; }
    }
}
