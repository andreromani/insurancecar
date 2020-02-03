using System;
using System.Collections.Generic;
using CarInsurance.Domain.Models;
using CarInsurance.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/carinsurance")]
    [ApiController]
    public class InsuranceController : Controller
    {
        private readonly IInsuranceService _insuranceService;

        public InsuranceController(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }

        [HttpGet("GetListInsurances", Name = "GetListInsurances")]
        public ActionResult<IEnumerable<Insurance>> Get()
        {
            try
            {
                return Ok(_insuranceService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpPost("PostInsurance", Name = "PostInsurance")]
        public ActionResult<Insurance> Post([FromBody] Insurance insurance)
        {
            try
            {
                _insuranceService.Add(_insuranceService.CalculateInsuranceValue(insurance));
                return Ok(insurance);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpGet("GetAveragePrices", Name = "GetAveragePrices")]
        public ActionResult GetAverage()
        {
            try
            {
                return Ok(_insuranceService.GetAverage());
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        [HttpGet("GetInsurance/{id}", Name = "GetInsurance")]
        public ActionResult<Insurance> GetById(int id)
        {
            try
            {
                return Ok(_insuranceService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}