using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    using System;

    interface Iprice
    {
        public double CalculatePrice(int quantity);
    }

    class Ingredient
    {
        private const double _sodaPrice = 15;
        private readonly int _sodaQuantity;
        private readonly int _alcoholQuantity;

        public Ingredient(int sodaQuantity, int alcoholQuantity)
        {
            _sodaQuantity = sodaQuantity;
            _alcoholQuantity = alcoholQuantity;
        }
        public double IngredientsAmount()
        {
            return (_sodaQuantity + _alcoholQuantity) * _sodaPrice;
        }
    }

    class BlueOcean : Iprice
    {
        private const int _sodaQuantity = 2;
        private const int _alcoholQuantity = 2;

        public double CalculatePrice(int quantity)
        {
            var ingredient = new Ingredient(_sodaQuantity, _alcoholQuantity);
            double result = ingredient.IngredientsAmount();
            return result * quantity;
        }
    }

    class Mojito : Iprice
    {
        private const int _sodaQuantity = 4;
        private const int _alcoholQuantity = 2;
        public double CalculatePrice(int quantity)
        {
            var ingredient = new Ingredient(_sodaQuantity, _alcoholQuantity);
            double result = ingredient.IngredientsAmount();
            return result * quantity;
        }
    }

    class PrepareBill
    {
        public double CalculateDrinkPrice(Func<int, double> calculatePrice, int quantity)
        {
            return calculatePrice(quantity);
        }
    }
    class ServingDrinks
    {
        public static void Main(string[] args)
        {
            Func<int, double> calculatorPrice = new BlueOcean().CalculatePrice;
            var amount = new PrepareBill().CalculateDrinkPrice(calculatorPrice, 10);
            Console.WriteLine($"{amount}");

            calculatorPrice = new Mojito().CalculatePrice;
            amount = new PrepareBill().CalculateDrinkPrice(calculatorPrice, 5);
            Console.WriteLine($"{amount}");
        }
    }
}
