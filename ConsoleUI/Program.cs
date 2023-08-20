using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProductDetailDtoTest();
            //AddMethod();
            //DeleteMethod();
            //GetByIdMethod();
            //GetAllMethod();
            //UpdatmMethod();

            CustomersForCarManager customers = new CustomersForCarManager(new EfCustomersForCarDal());
            var result = customers.Add(new CustomersForCar { UserId = 3, CompanyName = "LetGo Oto" });
           

        }       

        private static void UpdatmMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 1, BrandId = 1, ColourId = 1, DailyPrice = 1111, Description = "1.6 Tdi", ModelYear = 2020 });
        }

        private static void GetAllMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.ModelYear + " / " + car.ColourId);
            }
        }

        private static void GetByIdMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(2).Data);
        }

        /*private static void DeleteMethod()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.Delete(new Car { CarId = 5 });

            foreach (var car in carManager2.GetProductDetails().Data)
            {
                Console.WriteLine(car);
            }
        }

        private static void ProductDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetProductDetails().Data)
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColourName);
            }
        }

        private static void AddMethod()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Add(new Car { CarId = 5, BrandId = 3, ColourId = 2, DailyPrice = 1200 });
            

            foreach (var item in carManager1.GetProductDetails().Data)
            {
                Console.WriteLine(item.CarId + " / " + item.BrandName + " / " + item.ColourName);
            }
        }*/
    }
}
