using OnlineBookStore.Repositories;
using OnlineBookStore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddSession();

builder.Services.AddScoped<
    IBookRepository,
    BookRepository>();

builder.Services.AddMvc(options =>
{
    options.Filters
        .Add<GlobalExceptionFilter>();
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern:
    "{controller=Book}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "bookdetails",
    pattern: "books/{id:int}",
    defaults: new
    {
        controller = "Book",
        action = "Details"
    });

app.Run();