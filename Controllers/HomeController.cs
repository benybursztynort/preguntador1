using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using preguntador1.Models;

namespace preguntador1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ConfigurarJuego()
    {
        Juego.InicializarJuego();
        ViewBag.Categorias = BD.ObtenerCategorias();
        ViewBag.Dificultades = BD.ObtenerDificultades();
        return View();

    }
    public IActionResult Comenzar(string username, int dificultad, int categoria)
    {
        Juego.CargarPartida(username, dificultad, categoria);
        BD.ObtenerPreguntas(dificultad, categoria);
        if (ViewBag.Preguntas == null)
        {
            return RedirectToAction("Jugar", "Home");
        }
        else
        {
            return RedirectToAction("ConfigurarJuego", "Home");
        }
    }
    public IActionResult Jugar(int idPregunta)//LLAMAR AL PROFE
    {

        ViewBag.Username = Juego.username;
        ViewBag.pregunta = Juego.ObtenerProximaPregunta();
        if (ViewBag.pregunta == null)
        {
            return View("Juego");
        }
        else
        {
            ViewBag.respuesta = Juego.ObtenerProximasRespuestas(idPregunta);
            return View("Juego");
        }

    }
    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        ViewBag.Correcta = Juego.VerificarRespuesta(idPregunta, idRespuesta);
        return View("Respuesta");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
