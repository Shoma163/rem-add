using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class product
        
    {
        public product(string name, float price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
