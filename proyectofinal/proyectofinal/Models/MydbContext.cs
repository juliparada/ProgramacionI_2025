using Microsoft.EntityFrameworkCore;
namespace proyectofinal.Models
{
    public class MydbContext : DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options) : base(options) { }
        public DbSet<usuarioPaciente> usuarioPaciente { get; set; }

        //Conexion a la base de datos; a la tabla usuarioPaciente.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<usuarioPaciente>().HasKey(a =>a.idPacienteUsuario);
        }
    }
}
