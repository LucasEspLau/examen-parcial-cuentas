using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using examen_parcial_cuentas.Data;

namespace examen_parcial_cuentas.Controllers
{
    [Route("[controller]")]
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;
        private readonly ApplicationDbContext _context;

        public CuentaController(ILogger<CuentaController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }
        [HttpGet]

        public IActionResult Index()
        {
            var cuentas = from o in _context.Cuentas select o;

            return View("~/Views/Cuentas/Index.cshtml",cuentas.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}