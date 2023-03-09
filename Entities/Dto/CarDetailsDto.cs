using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CarDetailsDto : IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int ColourId { get; set; }
        public string ColourName { get; set; }
        public int ModelYear { get; set; }
        public float DailyPrice { get; set; }

    }
}
