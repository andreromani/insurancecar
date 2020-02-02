using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Domain.Models;
using CarInsurance.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/insurance")]
    [ApiController]
    public class InsuranceController : Controller
    {
        private readonly IInsuranceService _insuranceService;

        public InsuranceController(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Insurance>> Get()
        {            
            return _insuranceService.Get(new List<string> { "Car", "Insured" }).ToList();
        }

        [HttpPost]
        public void Post([FromBody] Insurance insurance)
        {
            _insuranceService.CalculateInsuranceValue(insurance);
            _insuranceService.Add(insurance);
        }

        [HttpGet("average")]
        public ActionResult GetAverage()
        {
            var average = _insuranceService.GetAverage();
            return Json(average);
        }
    }
}