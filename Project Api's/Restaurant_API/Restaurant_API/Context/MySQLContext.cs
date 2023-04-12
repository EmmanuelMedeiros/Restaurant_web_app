using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;

namespace Restaurant_API.Context {
    public class MySQLContext : DbContext {

        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<PratoCompleto> Pratos_Completos { get; set; }
        public DbSet<TiraGosto> TiraGostos { get; set; }
        public DbSet<Guarnicao> Guarnicoes { get; set; }
    }
}
