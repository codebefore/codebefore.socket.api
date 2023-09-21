using codebefore.socket.api;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


app.MapGet("/send/{message}", (string message, IHubContext<NotifyHub> _hubContext) =>
{
    _hubContext.Clients.All.SendAsync("codebeforesocket", message);
    return message;
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<NotifyHub>("/api/hubs/notifynumber");
});
app.Run();

