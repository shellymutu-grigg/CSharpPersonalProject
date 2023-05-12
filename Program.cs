using csharp_personal_project;
using csharp_personal_project.BusinessLogic;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
	{
		options.SwaggerDoc("v1", new OpenApiInfo
		{
			Version = "v1",
			Title = "Gardening API",
			Description = "An ASP.NET Core Web API for managing gardening tasks",
		});
	}
);

builder.Services.AddTransient<ISurfaceCalculator, MetricSurfaceCalculator>();
builder.Services.AddTransient<IGardenAreaService, GardenAreaService>();

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
