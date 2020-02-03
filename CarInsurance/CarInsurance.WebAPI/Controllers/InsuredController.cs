using System;
using System.Collections.Generic;
using System.Linq;
using CarInsurance.Domain.Models;
using CarInsurance.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/carinsurance")]
    [ApiController]
    public class InsuredController : Controller
    {
        private readonly IInsuredService _insuredService;

        public InsuredController(IInsuredService insuredService)
        {
            _insuredService = insuredService;
        }

        [HttpGet("GetListInsureds", Name = "GetListInsureds")]
        public ActionResult<IEnumerable<Insured>> Get()
        {
            try 
            { 
            return _insuredService.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
    }
}