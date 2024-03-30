using LMS_project_3.Interfaces;
using LMS_project_3.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Register controllers

// Add Razor Pages services
builder.Services.AddRazorPages();

// Dependency injection for repositories
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBorrowingRepository, BorrowingRepository>();
builder.Services.AddScoped<IReaderRepository, ReaderRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}*/

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map Razor Pages
app.MapRazorPages();

// Map controller routes
app.MapControllers();

app.Run();