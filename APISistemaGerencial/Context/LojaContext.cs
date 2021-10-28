using APISistemaGerencial.Models;
using Microsoft.EntityFrameworkCore; 

namespace APISistemaGerencial.Context
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> option) : base(option) { }
        public DbSet<Autorizacao> autorizacoes { get; set; }
        public DbSet<Aviso> avisos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<DadosExclusao> dadosExclusaos { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<Funcao> funcaos { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Log> logs { get; set; }
        public DbSet<Loja> lojas { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<ProdutosVendido> produtosVendidos { get; set; }
        public DbSet<Promocao> promocaos { get; set; }
        public DbSet<Venda> vendas { get; set; }
    }
}
