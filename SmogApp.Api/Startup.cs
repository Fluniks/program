using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmogApp.Core.Application.Command;
using SmogApp.Core.Application.Event;
using SmogApp.Core.Infrastructure.Command;
using SmogApp.Core.Infrastructure.Event;
using SmogApp.Core.Infrastructure.Query;
using SmogApp.Core.Presentation.Query;
using SmogApp.Users.Application;

namespace SmogApp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMediatR(GetAssemblyMarkers())
                .AddTransient<ICommandBus,CommandBus>()
                .AddTransient<IEventBus,EventBus>()
                .AddTransient<IQueryBus,QueryBus>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        private static Assembly[] GetAssemblyMarkers()
        {
            return new[] {typeof(AssemblyMarker).Assembly };
        }
    }
}