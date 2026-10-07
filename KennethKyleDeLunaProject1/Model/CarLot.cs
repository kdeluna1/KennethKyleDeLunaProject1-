using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    public class CarLot
    {
        private List<Car> Inventory;
        public decimal TaxRate = 0.078m;

        public int Count => Inventory.Count;
        public List<Car> LotInventory => new List<Car>(Inventory);

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

        public List<Car> FindCarsByMake(string make)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("Make cannot be null or empty.", nameof(make));
            }

            List<Car>? foundCars = Inventory.Where(car => car.Make.ToLower() == make.ToLower()).ToList();

            return foundCars;
        }

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

        public Car? FindLeastExpensiveCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }

            Car leastExpensiveCar = Inventory.Aggregate((car1, car2) => car1.Price < car2.Price ? car1 : car2);
            return leastExpensiveCar;
        }

        public Car? FindMostExpensiveCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }

            Car mostExpensiveCar = Inventory.Aggregate((car1, car2) => car1.Price > car2.Price ? car1 : car2);
            return mostExpensiveCar;
        }

        public Car? FindBestMpgCar()
        {
            if (Inventory == null || Inventory.Count == 0)
            {
                return null;
            }
            Car bestMpgCar = Inventory.Aggregate((car1, car2) => car1.Mpg > car2.Mpg ? car1 : car2);
            return bestMpgCar;
        }

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
