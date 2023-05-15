using API_Platform_Library.DAL;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// DB Context
builder.Services.AddDbContext<ApiPlatformContext>();

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        //Auto convert all enums/flags to their string name in JSON responses
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "API Platform Library",
        Version = "v0.01",
        Description = "Project to practice C#/.NET with multiple data schemas and API relay services",
        Contact = new OpenApiContact
        {
            Name = "Joe Allen",
            Email = "allen.joeg@gmail.com",
            Url = new Uri("https://github.com/AllenJoeG")
        }

    });
});



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
