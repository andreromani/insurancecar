using CarInsurance.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Repository.Context
{
    public class CarInsuranceContext : DbContext
    {
        public CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarMapping());
            modelBuilder.ApplyConfiguration(new InsuredMapping());
            modelBuilder.ApplyConfiguration(new InsuranceMapping());
        }
    }
}
