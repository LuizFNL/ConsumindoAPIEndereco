using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using consumindo_api.Services;
using consumindo_api.Models;

namespace consumindo_api.Controllers;

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

    public async Task<IActionResult> BuscarCEP(int cep)
    {
        try
        {
            Endereco endereco = new Endereco();
            EnderecoServices enderecoServices = new EnderecoServices();
            endereco = await enderecoServices.ConsumirAPI(cep);

            return View(endereco);
        }
        catch (System.Exception error)
        {

            return NotFound();
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
