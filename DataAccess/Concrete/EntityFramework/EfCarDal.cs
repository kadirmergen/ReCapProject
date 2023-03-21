﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Concrete;
using System.Linq;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<ProductDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join d in context.Colours
                             on c.ColourId equals d.ColourId
                             select new ProductDetailDto
                             {
                                 BrandName = b.BrandName, CarId=c.CarId, ColourName=d.ColourName, ModelYear= c.ModelYear
                             };
                return result.ToList();
            }
                                       
        }

        
    }
}
