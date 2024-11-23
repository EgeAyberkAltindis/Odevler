using ASpNetCoreMVC_BasicIdentity.Models.Context;
using ASpNetCoreMVC_BasicIdentity.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var connectionString=builder.Configuration.GetConnectionString("DefaultConnection");


//MiddleWare
builder.Services.AddDbContext<ProjectContext>(options=>options.UseSqlServer(connectionString));

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 6;


});

//Cookie Manager: İçerisinde küçük boyutlu verileri tutan ve bu verileri sadece browserda ulaşan küçük yapılardır.
builder.Services.ConfigureApplicationCookie(cookie =>
{
    
    cookie.Cookie = new CookieBuilder
    {
        Name="LoginCookie"
    };
   
    cookie.LoginPath = new PathString("/Home/Login");
    cookie.SlidingExpiration = true;
    cookie.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    

});



//CTRL+Shift+Space
//AddIdentity
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ProjectContext>();



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

app.UseAuthentication(); //kimlik yönetimi rol bazlı oturum için tanımlanması gereken servis
app.UseAuthorization(); //oturum

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
