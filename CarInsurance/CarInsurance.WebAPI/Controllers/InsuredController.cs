using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Domain.Models;
using CarInsurance.Service;
using CarInsurance.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.WebAPI.Controllers
{
    [Route("api/insured")]
    [ApiController]
    public class InsuredController : Controller
    {
        private readonly IInsuredService _insuredService;

        public InsuredController(IInsuredService insuredService)
        {
            _insuredService = insuredService;
        }
        public ActionResult<IEnumerable<Insured>> Get()
        {
            return _insuredService.Get().ToList();
        }
    }
}