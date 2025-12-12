using MathOperationsApp.Models;
using MathOperationsApp.Services;
using Microsoft.AspNetCore.Mvc;
namespace MathOperationsApp.Controllers;

public class HomeController : Controller
{
    private readonly IMathService _mathService;

    public HomeController(IMathService mathService)
    {
        _mathService = mathService;
    }

    public IActionResult Index()
    {
        int num1 = _mathService.GenerateRandomNumber();
        int num2 = _mathService.GenerateRandomNumber();

        var viewModel = new CalculationViewModel
        {
            Number1 = num1,
            Number2 = num2,
            Addition = _mathService.Add(num1, num2),
            Subtraction = _mathService.Subtract(num1, num2),
            Multiplication = _mathService.Multiply(num1, num2),
            Division = _mathService.Divide(num1, num2)
        };

        ViewBag.GeneratedAt = DateTime.Now.ToString("HH:mm:ss");
        ViewBag.Message = "Результаты операций с двумя случайными числами";

        return View(viewModel);
    }
}