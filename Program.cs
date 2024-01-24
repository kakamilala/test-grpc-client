using System.Text.Json;
using Grpc.Net.Client;
using GrpcClient;
using System.Diagnostics;
using Grpc.Core;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.Map("/", () => "GrpcClient");

app.MapGet("/accounts", (string phone, string pass) => {
    var user = new User(phone, pass);
    var controller = new Controller();
    var userData = controller.GetUserData(user);
    return userData;
});

app.Run();
