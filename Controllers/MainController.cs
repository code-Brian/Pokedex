using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using System.Text.Json;

namespace Pokedex.Controllers;
[ApiController]
[Route("api")]
public class MainController : Controller
{
    // Inject your DB Context into the controller
    private DBContext _context;
    private readonly ILogger<MainController> _logger;

    public MainController(ILogger<MainController> logger, DBContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("dummyData")]
    public async Task<ActionResult<Dictionary<string,string>>> TestData()
    {
        Dictionary<string, string> testData = new Dictionary<string, string>();
        testData.Add("name", "Johnny Appleseed");
        testData.Add("email", "johnny@appleseed.com");
        await Task.Delay(1500);
        return testData;
    }
    [HttpGet("pokemon")]
    public async Task<string> GetOnePokemon()
    {
        Dictionary<string, string> pokeResults = new Dictionary<string, string>();
        using(var client = new HttpClient())
        {
            var endpoint = new Uri("https://pokeapi.co/api/v2/pokemon/ditto");
            var result = await client.GetAsync(endpoint).Result.Content.ReadAsStringAsync();
            string json = JsonSerializer.Serialize(result);
            Console.WriteLine(result);
            return result;
        }
    }
}
