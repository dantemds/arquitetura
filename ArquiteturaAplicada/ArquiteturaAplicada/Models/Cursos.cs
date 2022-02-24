using System.ComponentModel.DataAnnotations;

namespace ArquiteturaAplicada.Models
{
    public class Cursos
    {
        [Key()]
        public int IdCurso { get; set; }
        public string NomeCurso { get; set; }
        public double ValorCurso { get; set; }
    }
}
