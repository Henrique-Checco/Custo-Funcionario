using CustoFuncionarioApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustoFuncionarioApp.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var custoTotal = funcionario.CalcularCustoTotal();
                ViewBag.CustoTotal = custoTotal;
                return View("Resultado");
            }
            return View("Index");
        }
    }
}
