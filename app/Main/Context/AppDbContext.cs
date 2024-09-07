using Main.Models;
using Microsoft.EntityFrameworkCore;

namespace Main.Context;

sealed public class AppDbContext : DbContext
{
    // Carrega as configurações do banco de dados
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Realiza o mapeamento das entidades para as tabelas do banco de dados
    public DbSet<Category> Categories { get; set; }
    public DbSet<Food> Foods { get; set; }
}
