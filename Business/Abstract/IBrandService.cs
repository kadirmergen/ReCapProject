using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetCarsByBrandId(int brandId);
        IDataResult<List<Brand>> GetBrands();
    }
}
