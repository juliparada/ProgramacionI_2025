using Microsoft.EntityFrameworkCore;
namespace proyectofinal.Models
{
    public class MydbContext : DbContext
    {
        public MydbContext(DbContextOptions<MydbContext> options) : base(options) { }
        public DbSet<usuarioPaciente> usuarioPaciente { get; set; }
        public DbSet<DatosPacientes> DatosPacientes { get; set; }

        //Conexion a la base de datos; a la tabla usuarioPaciente.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioPaciente>()
     .HasOne(u => u.DatosPacientes)
     .WithOne(d => d.usuarioPaciente)
     .HasForeignKey<DatosPacientes>(d => d.idPacienteUsuario);
            base.OnModelCreating(modelBuilder);


        }
    }
}
