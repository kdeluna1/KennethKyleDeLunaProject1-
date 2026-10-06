using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject1.Model
{
    internal class Shopper
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
    }
}
