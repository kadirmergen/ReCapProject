using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourService _colourService;

        public ColourManager(IColourService colourService)
        {
            _colourService = colourService;
        }

        public List<Car> GetCarsByColourId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
