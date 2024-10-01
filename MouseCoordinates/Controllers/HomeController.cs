using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MouseCoordinates.Models;
using MouseCoordinates.Services;

namespace MouseCoordinates.Controllers;

public class HomeController : Controller
{
    public HomeController() { }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SaveCoordinates()
    {
        using var reader = new StreamReader(Request.Body);

        string json = await reader
            .ReadToEndAsync()
            .ConfigureAwait(false);

        var coordinates = new CoordinatesViewModel(json);

        await DatabaseConnectionService.CoordinatesRepository
            .AddAsync(coordinates)
            .ConfigureAwait(false);

        return Index();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
