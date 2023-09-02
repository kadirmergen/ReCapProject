using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customersForCar)
        {

            _customerDal.Add(customersForCar);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customersForCar)
        {
            _customerDal.Delete(customersForCar);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {           
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.UserId == userId),Messages.CustomerSelected);
        }

        public IResult Update(Customer customersForCar)
        {
            _customerDal.Update(customersForCar);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
