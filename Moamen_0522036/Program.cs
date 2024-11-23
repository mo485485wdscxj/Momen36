using Microsoft.EntityFrameworkCore;
using Moamen_0522036;
using Moamen_0522036.InterFace;
using Moamen_0522036.Reposatories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>
    (option => option.UseSqlServer(builder.Configuration.GetConnectionString("Defutlconnection")));
builder.Services.AddScoped<IMoveRpo, MoviesRpo>();
builder.Services.AddScoped<ICatregoryRepo, CategoryRepo>();
builder.Services.AddScoped<INationalRepo, NationalRepo>();
builder.Services.AddScoped<IDirectoryRepo, DirectoryRepo>();


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
