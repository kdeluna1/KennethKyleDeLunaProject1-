using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    public class Shopper
    {
        /// <summary>
        /// The name of the shopper.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The funds that the shopper can spend.
        /// </summary>
        public decimal MoneyAvailable { get; set; }
        private List<Car> Cars;

        /// <summary>
        /// Creates a shopper instance.
        /// </summary>
        /// <param name="name">The name of the shopper</param>
        /// <param name="moneyAvailable">The money the shopper is able to spend</param>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Determines whther a shopper is able to purchase a car or not.
        /// </summary>
        /// <param name="totalcost"></param>
        /// <returns>True if the shopper is able to purchase a specific car and false if not.</returns>
        public bool CanPurchase(decimal totalcost)
        {
            return MoneyAvailable >= totalcost;
        }

        /// <summary>
        /// Purchases a car from the inventory.
        /// </summary>
        /// <param name="car">The car to be bought</param>
        /// <param name="totalCost"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Returns the list of cars that have been purchased.
        /// </summary>
        /// <returns></returns>
        public List<Car> PurchasedCars()
        {
            return Cars;
        }
    }
}
