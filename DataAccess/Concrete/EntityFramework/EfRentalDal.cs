using DataAccess.Abstract;
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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             select new RentalDetailDto { BrandName = b.BrandName, FirstName = u.FirstName, LastName = u.LastName};
                return result.ToList();
            }
        }
    }
}
