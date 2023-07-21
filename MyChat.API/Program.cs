
using MyChat.API;
using MyChat.API.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddSingleton<IDictionary<string, UserConnection>>(options => new Dictionary<string, UserConnection>());

var app = builder.Build();

app.UseCors();
app.MapHub<ChatHub>("/chat");

app.Run();
