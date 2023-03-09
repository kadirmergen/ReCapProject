using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if (car.BrandName.Length<2 && car.DailyPrice<0)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
            }
            else
            {
                _carDal.Add(car);
            }
            
        }


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
    }
}
