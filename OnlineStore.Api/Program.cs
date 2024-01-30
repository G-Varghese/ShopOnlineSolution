using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ShopOnline.Api.Data;
using ShopOnline.Api.Repositories.Contracts;


var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

		//***IMPORTANT INSTRUCTION HERE - MUST CONFIGURE CONNECTION BEFORE RUNNING MIGRATIONS
builder.Services.AddDbContextPool<ShopOnlineDbContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("ShopOnlineConnection"))
		);

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

		

app.MapControllers();


		
app.UseCors(policy =>
			policy.WithOrigins("http://localhost:7122", "https://localhost:7122")
			.AllowAnyMethod()
			.WithHeaders(HeaderNames.ContentType)
		);

		app.Run();
