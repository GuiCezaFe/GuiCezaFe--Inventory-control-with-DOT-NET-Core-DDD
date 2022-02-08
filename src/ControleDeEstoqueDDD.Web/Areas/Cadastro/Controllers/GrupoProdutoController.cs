using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ControleDeEstoqueDDD.Web.Models;

namespace ControleDeEstoqueDDD.Web.Controllers
{
    [Area("Cadastro")]
    public class GrupoProdutoController : Controller
    {
        private readonly ILogger<GrupoProdutoController> _logger;

        public GrupoProdutoController(ILogger<GrupoProdutoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
