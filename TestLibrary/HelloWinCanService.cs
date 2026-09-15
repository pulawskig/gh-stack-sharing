namespace TestLibrary;

public sealed class HelloWinCanService : IHelloWorldService
{
    public async Task<string> HelloWorldAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        return "Hello, WinCan!";
    }
}
