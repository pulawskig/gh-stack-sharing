using TestLibrary;

namespace API;

public static class HelloWorldApi
{
    public static void MapHelloWorldApi(this WebApplication app)
    {
        var helloService = app.Services.GetRequiredService<IHelloWorldService>();

        var helloApi = app.MapGroup("/hello");

        helloApi.MapGet("/", () => helloService.HelloWorldAsync())
                .WithName("HelloWorld");
    }
}
