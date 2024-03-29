namespace CatsServer
{
    using CatsServer.Infrastructure.Extensions;
    using Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDbContext>(options =>
            options
            .UseSqlServer(AppSettings.DatabaseConnectionString));
        }

        public void Configure(IApplicationBuilder app)
        {
            app
                .UseDatabaseMigration()
                .UseStaticFiles()
                .UseHtmlContentType()
                .UseRequestHandlers()
                .UseNotFoundHandler();
        }
    }
}
