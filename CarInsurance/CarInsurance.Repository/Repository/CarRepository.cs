using CarInsurance.Domain.Models;
using CarInsurance.Repository.Context;
using CarInsurance.Repository.Repository.Interfaces;

namespace CarInsurance.Repository.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(CarInsuranceContext context) : base(context)
        {
        }
    }
}
