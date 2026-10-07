using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    public class Shopper
    {
        public string Name { get; set; }
        public decimal MoneyAvailable { get; set; }
        private List<Car> Cars;

        public Shopper(string name, decimal moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            }
            if (moneyAvailable < 0)
            {
                throw new ArgumentException("Money available must be a positive value.", nameof(moneyAvailable));
            }
            Name = name;
            MoneyAvailable = moneyAvailable;
            Cars = new List<Car>();
        }

        public bool CanPurchase(decimal totalcost)
        {
            return MoneyAvailable >= totalcost;
        }

        public void PurchaseCar(Car car, decimal totalCost)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }
            if (totalCost < 0)
            {
                throw new ArgumentException("Total cost must be a positive value.", nameof(totalCost));
            }

            if (!CanPurchase(totalCost))
            {
                throw new InvalidOperationException("Insufficient funds to purchase the car.");
            }
            MoneyAvailable -= totalCost;
            Cars.Add(car);
        }

        public List<Car> PurchasedCars()
        {
            return Cars;
        }
    }
}
