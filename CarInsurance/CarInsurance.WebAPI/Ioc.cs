using CarInsurance.Repository.Repository;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service;
using CarInsurance.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CarInsurance.WebAPI
{
    public class Ioc
    {
        public static void AddRepositorysDependencies(IServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IInsuredRepository, InsuredRepository>();
            services.AddTransient<IInsuranceRepository, InsuranceRepository>();
        }
        public static void AddServicesDependencies(IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IInsuredService, InsuredService>();
            services.AddTransient<IInsuranceService, InsuranceService>();
        }

    }
}
