using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbCuestionarios;

namespace Negocio
{
    public class ServicioCuestionarios
    {
        private readonly CuestionariosEntities _dbContext;

        public ServicioCuestionarios()
        {
            _dbContext = new CuestionariosEntities();
        }

        public List<Cuestionarios> ObtenerCuestionarios()
        {
            return _dbContext.Cuestionarios.ToList();
        }

        public Cuestionarios ObtenerCuestionario(int idCuestionario)
        {
            return _dbContext.Cuestionarios.SingleOrDefault(c => c.IdCuestionario == idCuestionario);
        }

        public List<Preguntas> ObtenerPreguntas(int idCuestionario)
        {
            return _dbContext.Preguntas.Where(p => p.IdCuestionario == idCuestionario).ToList();
        }

        public List<Respuestas> ObtenerRespuestas(int idPregunta)
        {
            return _dbContext.Respuestas.Where(r => r.IdPregunta == idPregunta).ToList();
        }
        
        
    }
}
