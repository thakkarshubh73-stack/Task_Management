using Microsoft.EntityFrameworkCore;
using TaskManagement_BE.AppData;
using TaskManagement_BE.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// DbContext
builder.Services.AddDbContext<TaskManagementEntity>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TMDB")));

// Repository DI
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use middleware
app.UseCors("AllowAngular");
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
