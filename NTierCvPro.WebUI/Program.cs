using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.BusinessLayer.Concrete;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.EntityFremwork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

/* INJECTION ISLEMLERI */
builder.Services.AddDbContext<NTierCvProContext>();

builder.Services.AddScoped<IAdminDal, EfAdminDal>();
builder.Services.AddScoped<IDeneyimlerimDAl, EfDeneyimlerimDal>();
builder.Services.AddScoped<IEgitimlerimDal, EfEgitimlerimDal>();
builder.Services.AddScoped<IHakkimdaDal, EfHakkimdaDal>();
builder.Services.AddScoped<IHobilerimDal, EfHobilerimDal>();
builder.Services.AddScoped<IIletisimDal, EfIletisimDal>();
builder.Services.AddScoped<ISertifikalarimDal, EfSertifikalarimDal>();
builder.Services.AddScoped<ISosyalMedyaDal, EfSosyalMedyaDal>();
builder.Services.AddScoped<IYeteneklerimDal, EfYeteneklerimDal>();

builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IDeneyimlerimService, DeneyimlerimManager>();
builder.Services.AddScoped<IEgitimlerimService, EgitimlerimManager>();
builder.Services.AddScoped<IHakkimdaService, HakkimdaManager>();
builder.Services.AddScoped<IHobilerimService, HobilerimManager>();
builder.Services.AddScoped<IIletisimService, IletisimManager>();
builder.Services.AddScoped<ISertifikalarimService, SertifikalarimManager>();
builder.Services.AddScoped<ISosyalMedyaService, SosyalMedyaManager>();
builder.Services.AddScoped<IYeteneklerimService, YeteneklerimManager>();
/* INJECTION ISLEMLERI */

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
