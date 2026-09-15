namespace TestLibrary;

public sealed class HelloWorldService : IHelloWorldService
{
    public async Task<string> HelloWorldAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        return "Hello, World!";
    }
}
