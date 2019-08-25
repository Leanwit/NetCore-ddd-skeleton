namespace backend
{
    using Controllers.Courses;
    using Controllers.CoursesCounter;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using src.Mooc.Courses.Application.Create;
    using src.Mooc.Courses.Domain;
    using src.Mooc.Courses.Infrastructure;
    using src.Mooc.Courses.Infrastructure.EfCore;
    using src.Mooc.CoursesCounter.Application.Find;
    using src.Mooc.CoursesCounter.Domain;
    using src.Mooc.CoursesCounter.Infraestructure;
    using src.Mooc.CoursesCounter.Infraestructure.EfCore;
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

            services.AddScoped<CoursesPutController, CoursesPutController>();
            services.AddScoped<CourseCreator, CourseCreator>();
            services.AddScoped<CourseRepository, EfCoreCourseRepository>();
            services.AddScoped<DomainEventPublisher, SyncDomainEventPublisher>();
            
            services.AddScoped<CoursesCounterGetController, CoursesCounterGetController>();
            services.AddScoped<CoursesCounterFinder, CoursesCounterFinder>();
            services.AddScoped<CoursesCounterRepository, EfCoreCoursesCounterRepository>();

            services.AddDbContext<CourseContext>(options => options.UseMySQL(Configuration.GetConnectionString("MoocDatabase")));
            services.AddDbContext<CoursesCounterContext>(options => options.UseMySQL(Configuration.GetConnectionString("MoocDatabase")));

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