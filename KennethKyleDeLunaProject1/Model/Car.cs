using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    /// <summary>
    /// The main classs for a car object
    /// </summary>
    public class Car
    {
        /// <summary>
        /// The make of the car
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// the model of the car
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The Mpg (fuel efficiency) of the car
        /// </summary>
        public decimal Mpg { get; set; }

        /// <summary>
        /// The price the car is being sold for
        /// </summary>
        public decimal Price { get; set; } 

        /// <summary>
        /// Creates a car object
        /// </summary>
        /// <param name="make">The make of the car</param>
        /// <param name="model">The model of the car</param>
        /// <param name="mpg">The mpg of the  car</param>
        /// <param name="price">The price of the car</param>
        /// <exception cref="ArgumentException"></exception>
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
