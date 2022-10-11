using Business.Abstract;
using Business.Concrete;
using Context;
using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace TodoAppBackEnd
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {


            var connectionString = Configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<DbContext, InterviewContext>(options =>
            {
                options.UseSqlServer(connectionString);
                // options.EnableSensitiveDataLogging();
            });
            services.AddDbContext<DbContext, TodoContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(TodoRepository<>));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserService, UserManager>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TodoApp.WebAPI", Version = "v1.0" });
            });


        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApp.WebAPI V1.0"));
            }

            //   app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
