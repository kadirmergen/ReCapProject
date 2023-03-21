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
            //ProductDetaiTest();
            //AddMethod();
            //DeleteMethod();
            //GetTest();
                        
        }

        private static void GetTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Get(2);
        }

        private static void DeleteMethod()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.Delete(new Car { CarId = 5 });

            foreach (var car in carManager2.GetProductDetails())
            {
                Console.WriteLine(car);
            }
        }

        private static void ProductDetaiTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColourName);
            }
        }

        private static void AddMethod()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            carManager1.Add(new Car { CarId = 7, BrandId = 3, ColourId = 2, DailyPrice = 1200 });
            Console.WriteLine("--------");

            foreach (var item in carManager1.GetProductDetails())
            {
                Console.WriteLine(item.CarId + " / " + item.BrandName + " / " + item.ColourName);
            }
        }
    }
}
