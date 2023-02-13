using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// AddNewtonsoftJson() is a package to implement patch 
// AddXmlDataContractSerializerFormatters() means accept xml format

// We use Log to create file for logging Villa Endpoint result
// we install serilog.aspNetCore & serilog.sinks.file
// from nuget package manager
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("log/villaLogs.txt",rollingInterval: RollingInterval.Day).CreateLogger();

// to use the instlled package
builder.Host.UseSerilog();

builder.Services.AddControllers(options =>
{
    // means only accept JSON format in the API
    //options.ReturnHttpNotAcceptable = true;

}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
