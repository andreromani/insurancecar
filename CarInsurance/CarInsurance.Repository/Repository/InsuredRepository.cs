using CarInsurance.Domain.Models;
using CarInsurance.Repository.Context;
using CarInsurance.Repository.Repository.Interfaces;

namespace CarInsurance.Repository.Repository
{
    public class InsuredRepository : Repository<Insured>, IInsuredRepository
    {
        public InsuredRepository(CarInsuranceContext context) : base(context)
        {
        }
    }
}
