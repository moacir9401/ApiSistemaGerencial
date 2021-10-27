using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Models
{
    public class Funcao
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
    }
}
