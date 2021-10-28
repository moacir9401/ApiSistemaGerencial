using System;

namespace APISistemaGerencial.Models
{
    
    public class Venda
    {
        public Guid Id { get; set; }

        public string idCliente { get; set; }
        
        public Funcionario Funcionario { get; set; }
        
        public string FormaPagamento { get; set; }
        
        public string DataVenda { get; set; }
        
        public float ValorTotal { get; set; }
        public float? Desconto { get; set; }
        
        public string Observação { get; set; }
    }
}
