using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    internal class CarLot
    {
        private List<Car> cars;
        public const decimal TaxRate = 0.078m; // 8% tax rate
        
        public CarLot()
        {
            cars = new List<Car>();
        }

        private void StockLotWithDefaultInventory()
        {
            cars.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
            cars.Add(new Car("Chevrolet", "Camaro", 19.0m, 65401.23m));
            cars.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
            cars.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));
        }
    }
}
