using JobScribe_stranger_strings.Data;
using JobScribe_stranger_strings.Services.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CompanyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobScribeConnection")));

builder.Services.AddDbContext<ApplicantContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobScribeConnection")));

builder.Services.AddDbContext<CVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobScribeConnection")));

builder.Services.AddDbContext<JobOfferContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobScribeConnection")));

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
    builder =>
    {
        builder
            .WithOrigins("http://localhost:5173")                        
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
    }));    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();