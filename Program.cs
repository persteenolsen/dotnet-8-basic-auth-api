using WebApi.Authorization;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// add services to DI container
{
    var services = builder.Services;
    services.AddCors();
    services.AddControllers();

    // configure DI for application services
    services.AddScoped<IUserService, UserService>();
}

var app = builder.Build();

// configure HTTP request pipeline
{
    // global cors policy
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    // custom basic auth middleware
    app.UseMiddleware<BasicAuthMiddleware>();

    app.MapControllers();
}


// Note: For production (simply.com) it needs to be without localhost !
app.Run();

// Only for local developement !
//app.Run("http://localhost:4000");