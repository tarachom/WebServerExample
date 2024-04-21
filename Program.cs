class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.UseRouting();
        app.MapGet("/", Start);

        app.Run();
    }

    static async Task Start(HttpContext context)
    {
        HttpResponse response = context.Response;
        await response.WriteAsync("Ok");
    }
}