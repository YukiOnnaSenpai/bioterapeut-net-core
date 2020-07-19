using API.Controllers;
using API.Dao;
using API.Dao.Converter;
using API.Services;
using API.Services.Implementations;
using BioterapeutDAL.Models;
using BioterapeutDAL.Models.Classes;
using BioterapeutDAL.Repositories.Interfaces;
using BioterapeutDAL.Repository.Implementations.Classes;
using DAO.Converters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
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
            services.AddDbContext<BioterapeutContext>(options => options.UseSqlServer(@"Data Source = DESKTOP-UG4V85N; Initial Catalog = Bioterapeut.NET; Integrated Security=SSPI;"));
            //controllers

            //converters
            services.AddSingleton<IConverter<Appointment, AppointmentDao>, AppointmentConverter>();
            services.AddSingleton<IConverter<Location, LocationDao>, LocationConverter>();
            services.AddSingleton<IConverter<ApplicationUser, UserDao>, UserConverter>();
            services.AddSingleton<IConverter<Label, LabelDao>, LabelConverter>();
            services.AddSingleton<IConverter<RelationUserAppointment, RelationUADao>, RelationUAConverter>();
            services.AddSingleton<IConverter<Merchendise, MerchendiseDao>, MerchendiseConverter>();
            services.AddSingleton<IConverter<LabelTranslation, LabelTranslationDao>, LabelTranslationConverter>();
            //services
            services.AddSingleton<IService<AppointmentDao>, AppointmentService>();
            services.AddSingleton<IService<LabelDao>, LabelService>();
            services.AddSingleton<IService<LabelTranslationDao>, LabelTranslationService>();
            services.AddSingleton<IService<LocationDao>, LocationService>();
            services.AddSingleton<IService<MerchendiseDao>, MerchendiseService>();
            services.AddSingleton<IService<RelationUADao>, RelationService>();
            services.AddSingleton<IService<UserDao>, UserService>();

            services.AddSingleton<IRepository<Appointment, int>, AppointmentImpl>();
            services.AddSingleton<IRepository<RelationUserAppointment, int>, RelationUserAppointmentImpl>();
            services.AddSingleton<IRepository<Location, int>, LocationImpl>();
            services.AddSingleton<IRepository<Merchendise, int>, MerchendiseImpl>();
            services.AddSingleton<IRepository<ApplicationUser, int>, ApplicationUserImpl>();
            services.AddSingleton<IRepository<Label, int>, LabelImpl>();
            services.AddSingleton<IRepository<LabelTranslation, int>, LabelTranslationImpl>();
            services.AddControllers();
            
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
