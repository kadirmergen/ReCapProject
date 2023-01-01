using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId=1, BrandId=1, ColorId=12, DailyPrice=1998.5, ModelYear=2011, Description="Volkswagen Jetta 1.6 Primeline" },
                new Car{CarId=2, BrandId=2, ColorId=9, DailyPrice=2895.7, ModelYear=2017, Description="Skoda Octavia 1.6 TDI" },
                new Car{CarId=3, BrandId=2, ColorId=11, DailyPrice=3599.9, ModelYear=2020, Description="Skoda Octavia 1.6 Elite e-Tec"},
                new Car{CarId=4, BrandId=1, ColorId=12, DailyPrice=2200, ModelYear=2014, Description="Volkswagen Jetta 2.0 Comfortline" },
                new Car{CarId=5, BrandId=3, ColorId=7, DailyPrice=17599.9, ModelYear=2022, Description="Porsche Cayenne"}
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

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(Car car)
        {
            return _car.Where(p => p.CarId == car.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate= _car.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
