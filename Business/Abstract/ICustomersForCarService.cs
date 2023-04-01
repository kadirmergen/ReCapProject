using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomersForCarService
    {
        IResult Add(CustomersForCar customersForCar);
        IDataResult<List<CustomersForCar>> GetAll();
        IDataResult<CustomersForCar> GetById(int userId);
        IResult Update(CustomersForCar customersForCar);
        IResult Delete(CustomersForCar customersForCar);
    }
}
