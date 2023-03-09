using Business.Concrete;
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
            
            
            InMemoryCarDal inMemoryCar=new InMemoryCarDal();
            inMemoryCar.Add(new Car { CarId=6, BrandId=2, ColourId=11, DailyPrice=7500, ModelYear=2021, Description="Skoda Superb 2.0"}) ;
            foreach (var car in inMemoryCar.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }


        }
    }
}
