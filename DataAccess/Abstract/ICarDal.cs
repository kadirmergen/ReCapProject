using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
    }
}
