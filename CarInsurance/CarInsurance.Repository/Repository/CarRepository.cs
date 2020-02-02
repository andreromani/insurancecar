using CarInsurance.Domain.Models;
using CarInsurance.Repository.Context;
using CarInsurance.Repository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Repository.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarInsuranceContext context) : base(context)
        {
        }
    }
}
