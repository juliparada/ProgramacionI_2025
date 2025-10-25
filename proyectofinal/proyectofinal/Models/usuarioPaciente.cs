using System.ComponentModel.DataAnnotations;


namespace proyectofinal.Models
{
    public class usuarioPaciente
    {
        [Key]
        public int idPacienteUsuario { get; set; }

        public char email { get; set; }
        public string password { get; set; } = string.Empty;  

    }
}
