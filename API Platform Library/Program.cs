using API_Platform_Library.DAL;
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
