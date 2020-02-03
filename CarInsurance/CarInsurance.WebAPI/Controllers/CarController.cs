using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CarInsurance.Service.Interfaces;
using System.Collections.Generic;
using CarInsurance.Domain.Models;
using System;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/carinsurance")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetListCars", Name = "GetListCars")]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return _carService.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}