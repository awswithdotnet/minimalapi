WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.MapGet("/greeting", () => "aws w/ .NET");

app.Run("http://*:80");
