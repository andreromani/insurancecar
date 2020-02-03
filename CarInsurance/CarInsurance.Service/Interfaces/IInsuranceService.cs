using CarInsurance.Domain.Models;
using System.Collections.Generic;

namespace CarInsurance.Service.Interfaces
{
    public interface IInsuranceService : IService<Insurance>
    {
        Insurance CalculateInsuranceValue(Insurance insurance);
        double GetAverage();
        IEnumerable<Insurance> GetAll();
        Insurance GetById(int id);
    }

}
