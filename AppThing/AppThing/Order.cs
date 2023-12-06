using System;
using System.Collections.Generic;

namespace AppThing
{
    public class Order
    {
        private Product product = new();
        private List<Dictionary<string, double>> productList;
        private double total { get; set; }
        public BonusProvider Bonus { get; set; }


        public Order()
        {
            productList = product.ProductsList;
        }

        public void AddProduct(Product p)
        {
            product.Add(p.Name, p.Value);
        }

        public double GetValueOfProducts()
        {
            total = 0; // Reset total to 0 before calculating
            foreach (var productDictionary in productList)
            {
                foreach (var kvp in productDictionary)
                {
                    double productPrice = kvp.Value;
                    total += productPrice;
                }
            }
            return total;
        }

        public double GetBonus()
        {
            return Bonus?.Invoke(GetValueOfProducts()) ?? 0.0;
        }

        public double GetTotalPrice()
        {
            double valueOfProducts = GetValueOfProducts();
            double bonus = GetBonus();
            return valueOfProducts - bonus;
        }
    }
}
