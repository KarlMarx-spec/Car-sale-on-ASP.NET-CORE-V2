using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class CarViewModel
    {
        public int CarId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public int Hp { get; set; }
        public int RPM { get; set; }
        public int MaxSpeed { get; set; }
        public double TimeTo100 { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
