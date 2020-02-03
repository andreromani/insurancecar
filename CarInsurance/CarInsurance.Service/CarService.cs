using CarInsurance.Domain.Models;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service.Interfaces;

namespace CarInsurance.Service
{
    public class CarService : Service<Car>, ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository) : base(carRepository)
        {
            _carRepository = carRepository;
        }
    }
}
