using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api/email", () => {
    var list = new List<String>();
    list.Add("Google");
    list.Add("Microsoft");
    list.Add("Meta");
    return JsonSerializer.Serialize(list);
});

app.Run();
