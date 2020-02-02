using CarInsurance.Domain.Models;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarInsurance.Service
{
    public class InsuredService : Service<Insured>, IInsuredService
    {
        private readonly IInsuredRepository _insuredRepository;
        public InsuredService(IInsuredRepository insuredRepository) : base(insuredRepository)
        {
            _insuredRepository = insuredRepository;
        }
    }
}
