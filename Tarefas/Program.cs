using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tarefas.Data;
using Tarefas.Interfaces;
using Tarefas.Repository;
using Tarefas.Services;

var builder = WebApplication.CreateBuilder(args);
string conn = @"Server=Silas-pc\SQLEXPRESS;Database=Tarefas;Integrated Security=False;User Id=sa;Password=102030;TrustServerCertificate=True";
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer((conn) ?? throw new InvalidOperationException("Connection string 'Tarefas' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddScoped<INewTaskRepository, NewTaskRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<AuthService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");


app.Run();
