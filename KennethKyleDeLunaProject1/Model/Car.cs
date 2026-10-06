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
            if  (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or empty.", nameof(model));
            }
            if (mpg < 0)
            {
                throw new ArgumentException("MPG must be a positive value.", nameof(mpg));
            }
            if (price < 0)
            {
                throw new ArgumentException("Price must be a positive value.", nameof(price));
            }

            Make = make;
            Model = model;
            Mpg = mpg;
            Price = price;
        }
    }
}
