using CarInsurance.Domain.Models;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
