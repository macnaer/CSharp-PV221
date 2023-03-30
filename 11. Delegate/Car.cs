using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11._Delegate.Car;

namespace _11._Delegate
{
    internal class Car
    {
        int speed = 0;

        public delegate void ToFast();
        private ToFast toFast;
        
        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 20;
            if (speed >= 170) toFast();
            Console.WriteLine($"Current speed is: {speed}");
        }

        public void Breack()
        {
            speed -= 20;
        }

        public void RegisterOnTFast(ToFast toFast)
        {
            this.toFast = toFast;
        }
    }
}
