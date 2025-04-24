using Microsoft.AspNetCore.Mvc.Formatters;
using Packt.Shared;
using RChangLab5_CPT_206.Repositories;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using static System.Console;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IOrderRepository, OrderRepository>();


//CRUD

//Create, Retrieve, Update, and Delete



// Add services to the container.
builder.Services.AddNorthwindContext();
builder.Services.AddControllers(options =>
{
	WriteLine("Default output formatters: ");
	foreach(IOutputFormatter formatter in options.OutputFormatters)
	{
		OutputFormatter? mediaformmater = formatter as OutputFormatter;
		if(mediaformmater == null)
		{
			WriteLine($"{formatter.GetType().Name}.");
		}
		else
		{
		WriteLine(" {0}, Media Types: {1}", arg0: mediaformmater.GetType().Name, arg1: string.Join(", ",
			mediaformmater.SupportedMediaTypes));
		}
	}
}).AddXmlDataContractSerializerFormatters().AddXmlSerializerFormatters() ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
c.SwaggerDoc("v1", new() { Title = "CPT 206 Service Web API", Version = "v1" });
});

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>
	{
		c.SwaggerEndpoint("/swagger/v1/swagger.json", "CPT 206 Swagger Service API Version 1");
		c.SupportedSubmitMethods(new[] { SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete });
	});
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
