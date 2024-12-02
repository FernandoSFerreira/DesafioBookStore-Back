using DesafioBookStore_Back.Application;
using DesafioBookStore_Back.Infrastructure.Data;
using DesafioBookStore_Back.IoC;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;


var builder = WebApplication.CreateBuilder(args);


// Configurando o Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    //.WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Registrar o Serilog como o provedor de logging da aplicação
builder.Host.UseSerilog();

builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

// Configurando o DbContext para PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));


////Configurando o MongoDB
//builder.Services.AddSingleton<IMongoClient, MongoClient>(sp =>
//{
//    var settings = builder.Configuration.GetSection("MongoDbSettings");
//    return new MongoClient(settings["ConnectionString"]);
//});

DependencyInjection.Register(builder.Services);
builder.Services.AddAutoMapper(x => x.AddProfile(new EntityMapping()));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSerilogRequestLogging(); // Adiciona o logging de requisições com Serilog

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Middleware global para tratamento de erros
app.Use(async (context, next) =>
{
    try
    {
        await next.Invoke();
    }
    catch (Exception ex)
    {
        Log.Error(ex, "An unhandled exception occurred while processing the request.");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync(new { error = "An unexpected error occurred. Please try again later." });
    }
});

app.UseCors(a => a.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.Run();
