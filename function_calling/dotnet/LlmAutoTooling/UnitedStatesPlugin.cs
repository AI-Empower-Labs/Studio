using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

using Microsoft.SemanticKernel;

namespace LlmAutoTooling;

internal sealed class UnitedStatesPlugin
{
	[KernelFunction, Description("Get the United States population for a specific year")]
	public async Task<UnitedStatesResponse> GetPopulation([Description("The year")] string year)
	{
		string request = "https://datausa.io/api/data?drilldowns=Nation&measures=Population";
		using HttpClient client = new();
		UnitedStatesResult? result = await client.GetFromJsonAsync<UnitedStatesResult>(request);
		PopulationResults? populationData = result.data.FirstOrDefault(x => x.Year == year);

		UnitedStatesResponse response = new()
		{
			Gender = null,
			TotalNumber = populationData.Population,
			Year = year
		};

		return response;
	}

	[KernelFunction,
	Description("Get the United States population who identifies with a specific gender in a given year")]
	public async Task<UnitedStatesResponse> GetPopulationByGender(
		[Description("The year")] string year,
		[Description("The gender")] string? gender)
	{
		string request = "https://datausa.io/api/data?drilldowns=Year,Gender&measures=Total+Population";
		HttpClient client = new();
		GenderResult result = (await client.GetFromJsonAsync<GenderResult>(request))!;
		GenderResults? populationData = result.data.FirstOrDefault(results => results.Year == year && results.Gender.Equals(gender, StringComparison.CurrentCultureIgnoreCase));
		UnitedStatesResponse response = new()
		{
			Gender = gender,
			TotalNumber = populationData.TotalPopulation,
			Year = year
		};

		return response;
	}
}

public class UnitedStatesResponse
{
	[JsonPropertyName("year")]
	public string Year { get; set; }

	[JsonPropertyName("totalNumber")]
	public int TotalNumber { get; set; }

	[JsonPropertyName("gender")]
	public string? Gender { get; set; }
}

public class UnitedStatesResult
{
	public PopulationResults[] data { get; set; }
	public Source[] source { get; set; }
}

public class PopulationResults
{
	public string IDNation { get; set; }
	public string Nation { get; set; }
	public int IDYear { get; set; }
	public string Year { get; set; }
	public int Population { get; set; }
	public string SlugNation { get; set; }
}

public class Source
{
	public string[] measures { get; set; }
	public Annotations annotations { get; set; }
	public string name { get; set; }
	public object[] substitutions { get; set; }
}

public class Annotations
{
	public string source_name { get; set; }
	public string source_description { get; set; }
	public string dataset_name { get; set; }
	public string dataset_link { get; set; }
	public string table_id { get; set; }
	public string topic { get; set; }
	public string subtopic { get; set; }
}

public class GenderResult
{
	public GenderResults[] data { get; set; }
	public Source[] source { get; set; }
}

public class GenderResults
{
	public int IDYear { get; set; }
	public string Year { get; set; }
	public int IDGender { get; set; }
	public string Gender { get; set; }

	[JsonPropertyName("Total Population")]
	public int TotalPopulation { get; set; }
}
