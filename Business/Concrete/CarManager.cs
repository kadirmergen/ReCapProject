using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {

            if (car.DailyPrice>30000)
            {
                return new ErrorResult(Messages.CarPriceTooMuch);
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted) ;
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }

        

        //public void Add(Car car)
        //{
        //    if (car.BrandName.Length<2 && car.DailyPrice<0)
        //    {
        //        Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
        //    }
        //    else
        //    {
        //        _carDal.Add(car);
        //    }            
        //}


        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==13)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }
                
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>> (_carDal.GetCarDetails());
        }

        public IDataResult<Car> GetById(int carId)
        {                
            {
                return new SuccessDataResult<Car> (_carDal.Get(p => p.CarId == carId));
            }            
        }
    }
}
