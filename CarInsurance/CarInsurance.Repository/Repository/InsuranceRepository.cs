using CarInsurance.Domain.Models;
using CarInsurance.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Repository.Repository.Interfaces
{
    public class InsuranceRepository : Repository<Insurance>, IInsuranceRepository
    {
        public InsuranceRepository(CarInsuranceContext context) : base(context)
        {
        }
    }
}
