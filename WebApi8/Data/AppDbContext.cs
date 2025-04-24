using Microsoft.EntityFrameworkCore;
using WebApi8.Models;

namespace WebApi8.Data;

public class AppDbContext : DbContext
{
    //Construtor recebe opções de conexões que serão utilizadas no AppDbContext (serviço de meio-campo)
    public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
    {
    }
    
    public DbSet<AutorModel> Autores { get; set; }
    public DbSet<LivroModel> Livros { get; set; }

}
