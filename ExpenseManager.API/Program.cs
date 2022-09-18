using ExpenseManager.API.Constants;
using ExpenseManager.API.Infrastructure;
using ExpenseManager.API.Infrastructure.Contracts;
using ExpenseManager.API.Infrastructure.Repositories.Base;
using ExpenseManager.API.Services.Contract;
using ExpenseManager.API.Services.Core;
using ExpenseManager.API.Utilites;
using ExpenseManager.API.Utilites.APIExtension;
using Microsoft.EntityFrameworkCore;
using PAS.API.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.SetUpApi();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDbContext<ExpenseManagerDbContext>(ServiceLifetime.Scoped);
builder.Services.SetUpDatabase<ExpenseManagerDbContext>(builder.Configuration, DbConstant.MigrationTable, DbConstant.ExpenseManagerSchema);
builder.Services.Configure<ExpenseManagerOptions>(builder.Configuration.GetSection(ExpenseManagerOptions.ExpenseManager));
ExpenseManagerOptions expenseManagerOptions = new ExpenseManagerOptions();
builder.Configuration.Bind(ExpenseManagerOptions.ExpenseManager, expenseManagerOptions);
builder.Services.AddSingleton(expenseManagerOptions);

// Add services to the container.
builder.Services.AddScoped<IExpenseService, ExpenseService>();
builder.Services.AddScoped<IExpressionFilter, ExpressionFilter>();
builder.Services.AddScoped<IRepositoryService, RepositoryService>();

// Add Infrastructure layer
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//app.UsePathBase("/passervice");
using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
{
    var context = serviceScope.ServiceProvider.GetRequiredService<ExpenseManagerDbContext>();
    // context.Database.EnsureDeleted();
    context.Database.Migrate();
}
// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

// app.UseAuthorization();
app.ConfigureApi();
app.Run();