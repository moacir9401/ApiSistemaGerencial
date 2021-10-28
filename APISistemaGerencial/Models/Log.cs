using System;

namespace APISistemaGerencial.Models
{

    public class Log
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string Funcionario { get; set; }
        public string Data { get; set; }
        public string Motivo { get; set; }
    }
}
