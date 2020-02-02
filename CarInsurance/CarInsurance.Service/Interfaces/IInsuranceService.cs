using CarInsurance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarInsurance.Service.Interfaces
{
    public interface IInsuranceService : IService<Insurance>
    {
        Insurance CalculateInsuranceValue(Insurance insurance);
        double GetAverage();
    }

}
