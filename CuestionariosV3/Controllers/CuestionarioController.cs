using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Negocio;
using DbCuestionarios;
using CuestionariosV3.Models;

namespace CuestionariosV3.Controllers
{
    public class CuestionarioController : Controller
    {
        ServicioCuestionarios cuestionarios = new ServicioCuestionarios();

        public IActionResult Index()
        {
            return View(cuestionarios.ObtenerCuestionarios());
        }

        public IActionResult Detalle(int idCuestionario)
        {
            var cuestionario = cuestionarios.ObtenerCuestionario(idCuestionario);
            var preguntas = cuestionarios.ObtenerPreguntas(idCuestionario);
            var respuestas = cuestionarios.ObtenerRespuestas(idCuestionario);

            var modelo = new DetalleCuestionarioViewModel
            {
                Cuestionario = cuestionario,
                Preguntas = preguntas,
                Respuestas = respuestas
            };

            return View(modelo);
        }


        [HttpPost]
        public IActionResult Resultado(FormCollection form)
        {


            return View(form);
        }


    }
}
