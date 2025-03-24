using Flights.Server.ReadModels;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class FlightController : ControllerBase
{
    private Random random = new Random();
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<FlightController> _logger;

    public FlightController(ILogger<FlightController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Search")]
    public IEnumerable<FlightRm> Search()
        => new FlightRm[]
        {
            new (Guid.NewGuid(), 
                "American Airlines",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Los Angeles", DateTime.Now.AddHours(random.Next(1,3))),
                new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(4,10))),
                random.Next(1,853 )),
            new (Guid.NewGuid(),
                "Lufthansa",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Sibiu", DateTime.Now.AddHours(random.Next(1,10))),
                new TimePlaceRm("Munchen", DateTime.Now.AddHours(random.Next(4,15))),
                random.Next(1,853 )),
            new (Guid.NewGuid(),
                "Turkish Airlines",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("London", DateTime.Now.AddHours(random.Next(1,7))),
                new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(4,16))),
                random.Next(1,853 )),
            new (Guid.NewGuid(),
                "British Airways",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Manchester", DateTime.Now.AddHours(random.Next(1,3))),
                new TimePlaceRm("Madrid", DateTime.Now.AddHours(random.Next(4,8))),
                random.Next(1,853 )),
            new (Guid.NewGuid(),
                "Wizz Air",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Cluj-Napoca", DateTime.Now.AddHours(random.Next(1,4))),
                new TimePlaceRm("Prague", DateTime.Now.AddHours(random.Next(4,12))),
                random.Next(1,853 )),

            new (Guid.NewGuid(),
                "Qatar Airways",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Dubai", DateTime.Now.AddHours(random.Next(1,9))),
                new TimePlaceRm("Paris", DateTime.Now.AddHours(random.Next(4,15))),
                random.Next(1,853 )),
            new (Guid.NewGuid(),
                "Tarom",
                random.Next(90, 5000).ToString(),
                new TimePlaceRm("Bucharest", DateTime.Now.AddHours(random.Next(1,5))),
                new TimePlaceRm("Milano", DateTime.Now.AddHours(random.Next(4,12))),
                random.Next(1,853 ))
        };
}
