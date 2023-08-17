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
        return RedirectToAction("ConfigurarJuego","Home");
    }
     public IActionResult Comenzar(string username, int dificultad, int categoria, int idPreg, int idDificultad, int idCategoria)
    {
        Juego.CargarPartida(username,dificultad,categoria,idPreg,idDificultad,idCategoria);
        return View();
        //VERFIFICAR QUE ESTE BIEN
    }
    public IActionResult Jugar(List<Pregunta>ListaPreguntas)
    {
        ViewBag.preguntaYrespuesta=Juego.ObtenerProximaPregunta(ListaPreguntas);//NOSE PORUQE NO FUNCA
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
