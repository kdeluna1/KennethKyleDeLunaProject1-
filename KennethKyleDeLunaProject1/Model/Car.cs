using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Mpg { get; set; }
        public decimal Price { get; set; } 

        public Car(string make, string model, decimal mpg, decimal price)
        {
            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }
    }
}
