using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotNetTests
{
    class Startup
    {
        public IConfiguration Configuration { get; set; }

        public IConfiguration LoadConfiguration()
        {
            return new ConfigurationBuilder()
               .SetBasePath(System.IO.Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .AddJsonFile("appsettings.Development.json")
               .Build();
        }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<iMath, MathOperations>();
            services.AddTransient<iMath, MathOperations>();
            services.AddScoped<iMath, MathOperations>();
            services.Configure<ProgramOptions>(Configuration.GetSection(nameof(ProgramOptions)));
            services.AddApiVersioning(config =>
            {
                config.AssumeDefaultVersionWhenUnspecified = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/health", new HealthCheckOptions
                {

                });
            });
            lifetime.ApplicationStopping.Register(() =>
            {

            });
            lifetime.ApplicationStopped.Register(() =>
            {

            });
        }
    }
}
