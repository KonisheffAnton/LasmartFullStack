using Lasmart.Dto.Validation;
using Lasmart.WebApi.ExeptionHandlers;
using Lasmart.WebApi.Extensions;
using FluentValidation.AspNetCore;
using Lasmart.DataAccessLayer.DatabaseSetter;
using Lasmart.Business.DependecyResolver;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.RegisterDataAccess(config);
builder.Services.RegisterBusinessServices(config);

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidation();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.InitializeDatabase();

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapControllers();
app.UseDefaultFiles();
app.UseStaticFiles();


app.Run();
