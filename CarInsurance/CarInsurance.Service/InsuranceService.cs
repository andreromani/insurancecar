using CarInsurance.Domain.Models;
using CarInsurance.Repository.Repository;
using CarInsurance.Repository.Repository.Interfaces;
using CarInsurance.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInsurance.Service
{
    public class InsuranceService : Service<Insurance>, IInsuranceService
    {
        private readonly IInsuranceRepository _insuranceRepository;
        private readonly int safetyMargin = 3;
        private readonly int profit = 5;
        public InsuranceService(IInsuranceRepository insuranceRepository) : base(insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }
        public Insurance CalculateInsuranceValue(Insurance insurance)
        {
            double riskRate, riskPremium, purePrice, tradePremium;
            riskRate = ((insurance.Car.ValueCar * 5) / (2 * insurance.Car.ValueCar));
            riskPremium = (riskRate/100.00) * insurance.Car.ValueCar;
            purePrice = riskPremium * (1 + (safetyMargin/100.00));
            tradePremium = (profit/100.00) * purePrice;
            insurance.InsurancePrice = tradePremium + purePrice;
            return insurance;
        }

        public double GetAverage()
        {
            return _insuranceRepository.Get().Average(i => i.InsurancePrice);
        }
         

    }
}
