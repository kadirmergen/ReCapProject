using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService,IBrandService, IColourService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public Car Get(int id)
        {
            return _carDal.Get(p => p.CarId == id);
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


        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }
            

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetCarsByColourId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
