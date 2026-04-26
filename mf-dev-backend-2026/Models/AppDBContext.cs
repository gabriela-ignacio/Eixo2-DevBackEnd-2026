using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace mf_dev_backend_2026.Models
{
    // Classe responsável por representar o contexto do banco de dados da aplicação.
    // Esta classe pode ser utilizada para configurar a conexão com o banco de dados, definir as entidades e suas relações, e realizar operações de acesso aos dados.
    // A classe AppDBContext herda de DbContext, que é a classe base para o Entity Framework Core.

    public class AppDBContext: DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        
        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
