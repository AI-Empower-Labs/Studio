using System.ComponentModel;

using Microsoft.SemanticKernel;

namespace LlmAutoTooling;

internal sealed class WeatherPlugin
{
	[KernelFunction]
	[Description("Get the current weather in a given location.")]
	public string GetWeather(
		[Description("The city and department, e.g. Marseille, 13")]
		string location
	)
	{
		if (location.Contains("copenhagen", StringComparison.OrdinalIgnoreCase))
		{
			return $"The weather in {location} is around -12°C\nWind: 110 KMPH\nHumidity: 99%\nMostly cloudy";
		}

		return $"The weather in {location} is around 12°C\nWind: 11 KMPH\nHumidity: 48%\nMostly cloudy";
	}
}
