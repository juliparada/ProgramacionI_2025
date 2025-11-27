using System.ComponentModel.DataAnnotations;

namespace WebAppAcademica.Models
{
    public class Periodo {
        [Key]
        public int idPeriodo { get; set; }
        public string fecha { get; set; }
        public string periodo { get; set; }
    }
}