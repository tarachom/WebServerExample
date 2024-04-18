class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.UseRouting();
        app.MapGet("/", About);

        app.Run();
    }

    static async Task About(HttpContext context)
    {
        HttpResponse response = context.Response;
        await response.WriteAsync("Ok");
    }
}