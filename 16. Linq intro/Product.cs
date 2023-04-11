using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Linq_intro
{
    internal class Product
    {
        public string Name { get; set; }    
        public string Category { get; set; }

        public override string ToString()
        {
            return "Product: " + Name + " : " + Category;
        }
    }
}
