using ArquiteturaAplicada.Models;
using Microsoft.EntityFrameworkCore;

namespace ArquiteturaAplicada.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt): base (opt)
        {

        }

       public DbSet<Cursos> Cursos { get; set; }
    }
}
