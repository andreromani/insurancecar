using System;
using CarInsurance.Repository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CarInsurance.Service.Interfaces;
using System.Collections.Generic;
using CarInsurance.Domain.Models;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public ActionResult<IEnumerable<Car>> Get()
        {
            return _carService.Get().ToList();
        }

    }
}