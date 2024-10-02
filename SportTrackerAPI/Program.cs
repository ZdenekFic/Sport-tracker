using Microsoft.EntityFrameworkCore;
using SportTrackerAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Přidání služby pro kontroléry
builder.Services.AddControllers(); 

// Přidání CORS politiky
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Přidání databázového kontextu
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Použití CORS musí být zde, před autorizací a mapováním kontrolérů
app.UseCors();  // Aktivuje CORS s výchozí politikou, kterou jsme nastavili

app.UseAuthorization();

// Mapování kontrolérů na HTTP routy
app.MapControllers();

app.Run();

// Weather forecast se může ponechat
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
