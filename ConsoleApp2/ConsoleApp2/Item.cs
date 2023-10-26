using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Item
    {
        protected double Price { get; set; }

        public Item()
        {
            Price = 0;
        }
    }

    public class Fruit : Item
    {
        private double _weightInKg;
        private double _priceOfOneKg;

        public double WeightInKg { get => _weightInKg; set => _weightInKg = value; }
        public double PriceOfOneKg { get => _priceOfOneKg; set => _priceOfOneKg = value; }

        public void CalculateTotalPrice(double weightInKg, double priceOfOneKg)
        {
            _weightInKg = weightInKg;
            _priceOfOneKg = priceOfOneKg;
            Price = _weightInKg * _priceOfOneKg;
            Console.WriteLine($"Total price for the fruit is: {Price}");
        }
    }

    public class Electronics : Item
    {
        private int _quantity;
        private double _oneUnitPrice;

        public int Quantity { get => _quantity; set => _quantity = value; }
        public double OneUnitPrice { get => _oneUnitPrice; set => _oneUnitPrice = value; }

        public void CalculateTotalPrice(double oneUnitPrice, int quantity)
        {
            _oneUnitPrice = oneUnitPrice;
            _quantity = quantity;
            Price = _oneUnitPrice * _quantity;
            Console.WriteLine($"Total price for the electronic item is: {Price}");
        }
    }
}
