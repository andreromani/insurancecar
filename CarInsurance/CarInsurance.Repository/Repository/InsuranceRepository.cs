using CarInsurance.Domain.Models;
using CarInsurance.Repository.Context;

namespace CarInsurance.Repository.Repository.Interfaces
{
    public class InsuranceRepository : Repository<Insurance>, IInsuranceRepository
    {
        public InsuranceRepository(CarInsuranceContext context) : base(context)
        {
        }
    }
}
