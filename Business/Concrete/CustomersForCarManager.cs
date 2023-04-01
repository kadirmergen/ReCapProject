using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersForCarManager:ICustomersForCarService
    {
        ICustomersForCarDal _customersForCarDal;
        public CustomersForCarManager(ICustomersForCarDal customersForCarDal)
        {
            _customersForCarDal = customersForCarDal;
        }

        public IResult Add(CustomersForCar customersForCar)
        {
            if (customersForCar.CompanyName.Length<5)
            {
                return new ErrorResult(Messages.InvalidCompanyName);
            }

            _customersForCarDal.Add(customersForCar);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(CustomersForCar customersForCar)
        {
            _customersForCarDal.Delete(customersForCar);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<CustomersForCar>> GetAll()
        {           
            return new SuccessDataResult<List<CustomersForCar>>(_customersForCarDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<CustomersForCar> GetById(int userId)
        {
            return new SuccessDataResult<CustomersForCar>(_customersForCarDal.Get(p => p.UserId == userId),Messages.CustomerSelected);
        }

        public IResult Update(CustomersForCar customersForCar)
        {
            _customersForCarDal.Update(customersForCar);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
