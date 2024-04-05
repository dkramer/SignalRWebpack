var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

builder.Services.AddSignalR();

app.MapGet("/", () => "Hello World!");

app.Run();
