using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WAR_UI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var conn = "WARDbContext";//
builder.Services.AddDbContext<WARDbContext>(x => { x.UseSqlServer(builder.Configuration.GetConnectionString(conn)); });//
builder.Services.AddCors();//

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());//
app.UseRouting();//
app.UseAuthorization();


app.MapControllers();

app.Run();
