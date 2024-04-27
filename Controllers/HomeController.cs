using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using examen_parcial_cuentas.Models;
using examen_parcial_cuentas.Models.Entity;
using examen_parcial_cuentas.Data;

namespace examen_parcial_cuentas.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;

    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Cuenta()
    {
        return View();
    }
     [HttpPost]

    public async Task<IActionResult> Create(Cuenta objCuenta)
    {
        _context.Add(objCuenta);
        await _context.SaveChangesAsync();
        
        var message = $"Estimado(a) {objCuenta.Titular}, se creo su cuenta";
        TempData["Message"] = message;
        return View("~/Views/Home/Cuenta.cshtml");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
