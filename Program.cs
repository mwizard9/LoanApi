using LoanApi.Repositories.Implementation;
using LoanApi.Repositories.Interface;
using LoanApi.Service.Implementation;
using LoanApi.Service.Interface;
using Shared.Repositories.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient <IBranchService,BranchService>();
builder.Services.AddTransient<IBranchRepository, BranchRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddTransient<IGenericRepository, GenericRepositroy>();
builder.Services.AddTransient<IDapperRepository, DapperRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
