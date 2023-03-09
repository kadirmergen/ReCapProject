using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColourId=12, DailyPrice=1998.5, ModelYear=2011, Description="Volkswagen Jetta 1.6 Primeline" },
                new Car{CarId=2, BrandId=2, ColourId=9, DailyPrice=2895.7, ModelYear=2017, Description="Skoda Octavia 1.6 TDI" },
                new Car{CarId=3, BrandId=2, ColourId=11, DailyPrice=3599.9, ModelYear=2020, Description="Skoda Octavia 1.6 Elite e-Tec"},
                new Car{CarId=4, BrandId=1, ColourId=12, DailyPrice=2200, ModelYear=2014, Description="Volkswagen Jetta 2.0 Comfortline" },
                new Car{CarId=5, BrandId=3, ColourId=7, DailyPrice=17599.9, ModelYear=2022, Description="Porsche Cayenne"}
            };
            
        }
        public void Add(Car car)
        {
            _car.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            return _car.Where(p => p.CarId == car.CarId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate= _car.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColourId = car.ColourId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
