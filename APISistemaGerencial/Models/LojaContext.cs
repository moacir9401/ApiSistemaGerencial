using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISistemaGerencial.Models
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> option) : base(option) { }

        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Funcao> funcaos { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
    }
}
