using Microsoft.EntityFrameworkCore;
using Yummy.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationsYummyDbContext>(opt =>
{
    opt.UseSqlServer("Server=localhost;Database=YummyRelations;Integrated Security=false;User Id=sa;Password=p231sqlserver!!;");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.Run();

