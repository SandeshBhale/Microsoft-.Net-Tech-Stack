using AngularTaskAPI.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<EmployeeContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("scon")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(

     opt => {
         opt.AddDefaultPolicy(
              p => {
                  p.AllowAnyOrigin();
                  p.AllowAnyMethod();
                  p.AllowAnyHeader();
              }
             );
     }
    );
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.MapControllers();
app.Run();
