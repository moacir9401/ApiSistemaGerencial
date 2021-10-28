
using System;

namespace APISistemaGerencial.Models
{
    
    public class Autorizacao 
    {
        public Guid Id { get; set; }
        public string IdFuncao { get; set; }        
        public string Descricao { get; set; }        
        public bool Autorizado { get; set; }
    }
}
