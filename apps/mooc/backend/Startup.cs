namespace backend
{
    using Controllers.Courses;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using src.Mooc.Courses.Application.Create;
    using src.Mooc.Courses.Domain;
    using src.Mooc.Courses.Infrastructure;
    using src.Shared.Domain.Bus.Event;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<ICoursesPutController, CoursesPutController>();
            services.AddScoped<CourseCreator, CourseCreator>();
            services.AddScoped<CourseRepository, EfCourseRepository>();
            services.AddScoped<DomainEventPublisher, SyncDomainEventPublisher>();

            services.AddDbContext<CourseContext>(options => options.UseMySQL(Configuration.GetConnectionString("CourseDatabase")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes => { routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}"); });
        }
    }
}