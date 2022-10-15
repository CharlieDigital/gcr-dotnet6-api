var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Urls.Add("http://0.0.0.0:8080");

app.MapGet("/", () =>
{
  return $"Hello, World @ {DateTime.UtcNow} - version 3!!!";
})
.WithName("hello");

app.Run();
