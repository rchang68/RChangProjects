using Microsoft.AspNetCore.Mvc;

namespace RChangLab5_CPT_206.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}


		//GET
		[HttpGet]
		public IEnumerable<WeatherForecast> Get() 
		{
			return Get(5);
		}

		[HttpGet("{days:int}")]
		public IEnumerable<WeatherForecast>Get(int days)
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray();
		}

	}
}
