using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    /*
     DbContext es el objeto con la configuración para conectar el proyecto con la base de datos
     */
    public class ApplicationDbContext : DbContext
    {
        /*
         Options en este caso lo que hace es que la configuración que se establezca en DbContextOptions pasa a la clase base DbContext
         */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
