var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// AddNewtonsoftJson() is a package to implement patch request

// AddXmlDataContractSerializerFormatters() means accept xml format
builder.Services.AddControllers(options =>
{
    // means only accept JSON format in the API
    options.ReturnHttpNotAcceptable = true;

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
