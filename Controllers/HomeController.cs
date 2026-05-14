using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }

    public IActionResult generarSugerencia(sugeridorReceta datos){
        ViewBag.Plato = datos.determinarPlato();
        ViewBag.Tiempo = datos.calcularTiempo();
        ViewBag.Dificultad = datos.determinarDificultad();
        ViewBag.Sg = datos;
        return View("Resultado");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
