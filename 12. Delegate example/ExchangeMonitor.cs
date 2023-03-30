using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Delegate_example
{
    internal class ExchangeMonitor
    {
        public delegate void PriceExchange(int price);
        public PriceExchange priceExchange { get; set; }
        public void Start()
        {
            while (true)
            {
                int currancyPrice = (new Random().Next(40));
                priceExchange(currancyPrice);
                Thread.Sleep(3000);
            }
        }
    }
}
