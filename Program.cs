using MongoDB.Driver;
using API_ToDo.Services.Compras;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("DbConnection");
var mongoClient = new MongoClient(connectionString);
var dataBaseName = "ToDo";
var dataBase = mongoClient.GetDatabase(dataBaseName);

builder.Services.AddSingleton<IMongoClient>(mongoClient);
builder.Services.AddSingleton<IMongoDatabase>(dataBase);

builder.Services.AddScoped<ICompraAppService, CompraAppService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
