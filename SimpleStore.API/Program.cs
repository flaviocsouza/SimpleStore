using Microsoft.EntityFrameworkCore;
using SimpleStore.API.Utils;
using SimpleStore.Infra.DbConfiguration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositories();
builder.Services.AddAutoMapper(typeof(SimpleStoreProfile).Assembly);

builder.Services.AddDbContext<SimpleStoreDbContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SimpleStoreConnectionString")));


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
