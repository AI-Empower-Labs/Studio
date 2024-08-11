#pragma warning disable SKEXP0001

using LlmAutoTooling;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

IKernelBuilder builder = Kernel.CreateBuilder();
builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddConsole().SetMinimumLevel(LogLevel.Debug));
builder.Services.AddKeyedSingleton<IChatCompletionService>("llama3", Llama3Factory);

Kernel kernel = builder.Build();

kernel.ImportPluginFromObject(new WeatherPlugin(), nameof(WeatherPlugin));
kernel.ImportPluginFromObject(new UnitedStatesPlugin(), nameof(UnitedStatesPlugin));
KernelArguments kernelArguments = new(new OpenAIPromptExecutionSettings
{
	ServiceId = "llama3",
	Temperature = 0.1,
	ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
});

FunctionResult functionResult = await kernel.InvokePromptAsync("what is the population for us in 2020", kernelArguments);
Console.Out.WriteLine(functionResult);

return;

OpenAIChatCompletionService Llama3Factory(IServiceProvider sp, object? serviceId)
{
	Uri uri = new("http://localhost:8080/api/openai/v1/chat/completions");
	return new(
		"llama3",
		"NotNeeded",
		null,
		new HttpClient(new RequestUriReWriterHandler(uri, sp.GetRequiredService<ILogger<RequestUriReWriterHandler>>(), true, true)),
		sp.GetService<ILoggerFactory>());
}
