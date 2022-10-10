using Apiwithentity.Model;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IToplistRepository, ToplistSqlImpl>();
builder.Services.AddTransient<IUserWishlistRepository, WishlistSqlImpl>();

builder.Services.AddTransient<IBooksRepository, BooksSqlImpl>();
builder.Services.AddTransient<ICategoryRepository, CategorySqlImpl>();
builder.Services.AddTransient<ICustomerdetailsRepository, CustomerdetailsSqlImpl>();

builder.Services.AddTransient<ICartRepository, CartSqlImpl>();
builder.Services.AddTransient<IUserdetailsRepository, UserdetailsSqlImpl>();
builder.Services.AddDbContextPool<ToplistDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("mydb"));
}
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200");
            policy.WithHeaders("*");
            policy.WithMethods("*");


        }
        );
});
  



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors();
app.Run();
