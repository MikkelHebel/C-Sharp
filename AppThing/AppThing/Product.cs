using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppThing
{
    public class Product
    {
        public string Name {  get; set; }
        public double Value { get; set; }

        public List<Dictionary<string, double>> ProductsList = new();

        public void Add(string name, double value)
        {
            Dictionary<string, double> productDictionary = new Dictionary<string, double>
            {
                { name, value }
            };
            // Add to dict
            ProductsList.Add(productDictionary);
        }
    }
}
