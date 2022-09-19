using sibintek_test_task.Data.DbPostgreSQL;
using Microsoft.EntityFrameworkCore;
using sibintek_test_task.Data.interfaces;
using sibintek_test_task.Data.repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDBContext>(x=>x.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
builder.Services.AddTransient<ISibintekFile, FilesRepository>();
// builder.Services.AddTransient<ISibintekFile, MockISibintekFiles>();


var app = builder.Build();

// Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
// }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// DBObjects.Initial(app);

app.Run();

// using Microsoft.AspNetCore;
// using Microsoft.AspNetCore.Hosting;

// namespace sibintek_test_task {
//     public class Program {
//         public static void Main(string[] args) {
//             CreateWebHostBuilder(args).Build().Run();
//         }

//         public static IWebHostBuilder CreateWebHostBuilder(string[] args) => 
//             WebHost.CreateDefaultBuilder(args)
//                 .UseStartup<Startup>();
//     }
// }