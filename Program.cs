using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Logging;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// AddNewtonsoftJson() is a package to implement patch 
// AddXmlDataContractSerializerFormatters() means accept xml format

// We use Log to create file for logging Villa Endpoint result
// we install serilog.aspNetCore & serilog.sinks.file
// from nuget package manager
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("log/villaLogs.txt",rollingInterval: RollingInterval.Day).CreateLogger();

//// to use the instlled package
//builder.Host.UseSerilog();

//
builder.Services.AddDbContext<ApplicationDbContext>(Op =>
{
    // builder.Configuration used to access
    // the appsettings.json to get connection string of DB

    Op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});


builder.Services.AddControllers(options =>
{
    // means only accept JSON format in the API
    //options.ReturnHttpNotAcceptable = true;

}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// There 3 types of servise that catogrize depends on the services life
//1. AddSingleton --> This created when the application starte and that object will still running every time the requests an implementation (The longest one)
//2. AddScooped --> For every request it will create a new object and provide that where it is requested
//3. AddTransient --> let is say even in one request if that object is accessed like 10 times so, it will create 10 differnrt objects
// we implement the below code to implement log for the endpoints
builder.Services.AddSingleton<ILogging, Logging2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
