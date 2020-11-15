using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Week7DayMR
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add ApplicationDbContext to Dependency injection
            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer("Server=.;Database=entityframework;Trusted_Connection=True;MultipleActiveResultSets=true"));

            services.AddMvc();
            //using (var context = new ApplicationDbContext())
            //{
            //    context.Database.EnsureCreated(); // Make sure we have the database
            //    if(!context.Settings.Any()) // if the database doesn't exists...
            //    {
            //        context.Settings.Add(new SettingsDataModel
            //        {
            //            Name = "BackgroundColor",
            //            Value = "Red"
            //        });
            //        var settingsLocally = context.Settings.Local.Count();   // data stored on our computer
            //        var settingsDatabase = context.Settings.Count();        // data in the database

            //        var firstLocal = context.Settings.Local.FirstOrDefault();   // compare the first value in our dataset
            //        var firstDatabase = context.Settings.FirstOrDefault();      // vs the firts item in the database

            //        context.SaveChanges();          // commits the chnages to the database
            //    }
            //}

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
