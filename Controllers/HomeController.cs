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

    public IActionResult ConfigurarJuego(int idCategoria,int idDificultad)
    {
        Juego.InicializarJuego();
        ViewBag.Categorias= BD.ObtenerCategorias(idCategoria);
        ViewBag.Dificultades= BD.ObtenerDificultades(idDificultad);
        viewBag.Preguntas= Juego.ObtenerProximaPregunta(ListaPreguntas);
        if(viewBag.Preguntas==null){
             return RedirectToAction("Jugar","Home");
        } else{
        return RedirectToAction("ConfigurarJuego","Home");
        }
    }
     public IActionResult Comenzar(string username, int dificultad, int categoria, int idPreg, int idDificultad, int idCategoria)
    {
        Juego.CargarPartida(username,dificultad,categoria,idPreg,idDificultad,idCategoria);
        return View();
        //VERFIFICAR QUE ESTE BIEN
    }
    public IActionResult Jugar(List<Pregunta>ListaPreguntas, int idPregunta)
    {
         ViewBag.pregunta=Juego.ObtenerProximaPregunta(ListaPreguntas);
        if(viewBag.pregunta==null){
             return View("Fin");}
             else{
         viewBag.respuesta=Juego.ObtenerProximasRespuestas(idPregunta);
         return view("Juego");
        }
       
    }
    [HttpPost] public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta){
        viewBag.Correcta=Juego.VerificarRespuesta();
        return view("Respuesta");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
