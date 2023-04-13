using BlogAPI.Contexts;
using BlogAPI.Repositories;
using BlogAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<ArticleRepository>();
builder.Services.AddScoped<ArticleAuthorRepository>();
builder.Services.AddScoped<ArticleTagRepository>();
builder.Services.AddScoped<ContentTypeRepository>();
builder.Services.AddScoped<ArticleService>();




var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
