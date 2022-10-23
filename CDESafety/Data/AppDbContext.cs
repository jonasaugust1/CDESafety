using CDESafety.Models;
using Microsoft.EntityFrameworkCore;

namespace CDESafety.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>()
                .HasMany(clientes => clientes.Propriedades)
                .WithMany(propriedades => propriedades.Clientes);

            builder.Entity<RelatorioDeServico>()
                .HasMany(rs => rs.Equipamentos)
                .WithMany(e => e.RelatorioDeServicos);

            builder.Entity<RelatorioDeServico>()
                .HasOne(rs => rs.Piloto)
                .WithMany(p => p.RelatorioDeServico)
                .HasForeignKey(rs => rs.PilotoId);

            builder.Entity<RelatorioDeServico>()
                .HasOne(rs => rs.Aeronave)
                .WithMany(a => a.RelatorioDeServicos)
                .HasForeignKey(rs => rs.AeronaveId);

            builder.Entity<RelatorioDeServico>()
                .HasOne(rs => rs.Pista)
                .WithMany(p => p.RelatorioDeServicos)
                .HasForeignKey(rs => rs.PistaId);

            builder.Entity<RelatorioDeServico>()
                .HasMany(rs => rs.Clientes)
                .WithMany(c => c.RelatorioDeServicos);

            builder.Entity<RelatorioDeServico>()
                .HasMany(rs => rs.Propriedades)
                .WithMany(p => p.RelatorioDeServicos);

            builder.Entity<RelatorioDeServico>()
                .HasMany(rs => rs.Culturas)
                .WithMany(c => c.RelatorioDeServicos);

            builder.Entity<RelatorioDeServico>()
                .HasMany(rs => rs.Ajudantes)
                .WithMany(a => a.RelatorioDeServicos);

        }

        public DbSet<Aeronave> Aeronaves { get; set; }
        public DbSet<Ajudante> Ajudantes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cultura> Culturas { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<Pista> Pistas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<RelatorioDeServico> RelatorioDeServicos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Propriedade> Propriedades { get; set; }
    }
}
