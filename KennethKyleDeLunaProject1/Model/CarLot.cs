using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    /// <summary>
    /// The Inventory class that lists the cars in te inventory
    /// </summary>
    public class CarLot
    {
        private List<Car> Inventory;

        /// <summary>
        /// The basic tax rate for vehicles being sold
        /// </summary>
        public decimal TaxRate = 0.078m;

        public int Count => Inventory.Count;
        public List<Car> LotInventory => new List<Car>(Inventory);

        /// <summary>
        /// initializes a new CarLot list of cars
        /// </summary>
        public CarLot()
        {
            Inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            Inventory.Add(new Car("Chevrolet", "Camaro", 19.0m, 65401.23m));
            Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
            Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }

        /// <summary>
        /// Finds cars of a given make
        /// </summary>
        /// <param name="make">The make to filter the cars by</param>
        /// <returns>A list of cars of the same make</returns>
        /// <exception cref="ArgumentException"></exception>
        public List<Car> FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));
            }

            List<Car>? foundCars = Inventory.Where(car => car.Make.ToLower() == make.ToLower()).ToList();

            return foundCars;
        }

        /// <summary>
        /// Finds cars of the same make and model
        /// </summary>
        /// <param name="make">The make to be matched</param>
        /// <param name="model">The model to be matched</param>
        /// <returns>A list of cars that matc the given make and model</returns>
        /// <exception cref="ArgumentException"></exception>
        public List<Car> FindCarByMakeModel(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or empty.", nameof(model));
            }

            List<Car>? foundCars = Inventory.Where(car => car.Make.ToLower() == make.ToLower() && car.Model.ToLower() == model.ToLower()).ToList();

            return foundCars;
        }

        /// <summary>
        /// Purchases a car from the list based on the make and model
        /// </summary>
        /// <param name="make">The make of the car to be bought</param>
        /// <param name="model">The model of the car to be bought</param>
        /// <returns>Returns the car to be bought or null if funds are insufficient</returns>
        /// <exception cref="ArgumentException"></exception>
        public Car? PurchaseCar(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));
            }
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or empty.", nameof(model));
            }

            Car? carToPurchase = Inventory.FirstOrDefault(car => car.Make.ToLower() == make.ToLower() && car.Model.ToLower() == model.ToLower());

            if (carToPurchase != null)
            {
                Inventory.Remove(carToPurchase);
                return carToPurchase;
            }
            return null; 
            
        }

        /// <summary>
        /// Adds aa car to the inventory
        /// </summary>
        /// <param name="make">The make of the car to be addded</param>
        /// <param name="model">The model of the car to be added</param>
        /// <param name="mpg">The mpg of the car to be added</param>
        /// <param name="price">The price of the car to be added</param>
        /// <exception cref="ArgumentException"></exception>
        public void AddCar(string make, string model, decimal mpg, decimal price)
        {
            if (string.IsNullOrWhiteSpace(make))
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
            Car newCar = new Car(make, model, mpg, price);
            Inventory.Add(newCar);
        }

        /// <summary>
        /// Gets the total cost of a purchase after taxes
        /// </summary>
        /// <param name="car">The car to be bought</param>
        /// <returns>The total price of the car</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public decimal GetTotalCostOfPurchase(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car cannot be null.");
            }
            decimal taxAmount = car.Price * TaxRate;
            decimal totalCost = car.Price + taxAmount;
            return totalCost;
        }

        /// <summary>
        /// Finds the least expensive car
        /// </summary>
        /// <returns>The car with the lowest price</returns>
        public Car? FindLeastExpensiveCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }

            Car leastExpensiveCar = Inventory.Aggregate((car1, car2) => car1.Price < car2.Price ? car1 : car2);
            return leastExpensiveCar;
        }

        /// <summary>
        /// Finds the most expensive car
        /// </summary>
        /// <returns>The car with the highest price</returns>
        public Car? FindMostExpensiveCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }

            Car mostExpensiveCar = Inventory.Aggregate((car1, car2) => car1.Price > car2.Price ? car1 : car2);
            return mostExpensiveCar;
        }

        /// <summary>
        /// Finds the most fuel efficient car
        /// </summary>
        /// <returns>The car with the highest fuel efficiency</returns>
        public Car? FindBestMpgCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }
            Car bestMpgCar = Inventory.Aggregate((car1, car2) => car1.Mpg > car2.Mpg ? car1 : car2);
            return bestMpgCar;
        }

        /// <summary>
        /// Finds the least fuel efficient car
        /// </summary>
        /// <returns>The car with the lowest fuel efficiency</returns>
        public Car? FindWorstMPG()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }
            Car worstMpgCar = Inventory.Aggregate((car1, car2) => car1.Mpg < car2.Mpg ? car1 : car2);
            return worstMpgCar;
        }
    }
}
