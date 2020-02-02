using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Repository.Context;
using CarInsurance.Repository.Repository;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service;
using CarInsurance.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarInsurance.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IInsuredRepository, InsuredRepository>();
            services.AddTransient<IInsuranceRepository, InsuranceRepository>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IInsuredService, InsuredService>();
            services.AddTransient<IInsuranceService, InsuranceService>();
            services.AddEntityFrameworkOracle().AddDbContext<CarInsuranceContext>(options =>
            {
                options.UseOracle(Configuration.GetConnectionString("DefaultConnection"));

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
