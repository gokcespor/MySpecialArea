using MediatR;
using Microsoft.EntityFrameworkCore;
using MySpecialArea.Data.Context;
using MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPost;
using MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategory;
using MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessage;
using MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTag;
using MySpecialArea.Shared.Operation.Operations.User.Query.GetUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("AppConnectionString"); // ayýrmamýzýn nedeni debug yaparken veri gelip gelmiyor mu diye kontrol etmek
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(typeof(GetUserRequest).Assembly));
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(typeof(GetTagRequest).Assembly));
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(typeof(GetMessageRequest).Assembly));
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(typeof(GetCategoryRequest).Assembly));
builder.Services.AddMediatR(m => m.RegisterServicesFromAssemblies(typeof(GetBlogPostRequest).Assembly));
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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
