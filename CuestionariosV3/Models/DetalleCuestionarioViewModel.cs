using DbCuestionarios;

namespace CuestionariosV3.Models
{
    public class DetalleCuestionarioViewModel
    {
        public Cuestionarios? Cuestionario { get; set; }
        public List<Preguntas>? Preguntas { get; set; }
        public List<Respuestas>? Respuestas { get; set; }
    }

}