using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Interfaces
{
    abstract internal class Vehicle
    {
        string Model { get; set; } = string.Empty;
        string Brand { get; set; } = string.Empty;
        DateOnly Date { get; set;  }
        ushort Power { get; set; }
        ushort Speed { get; set; }
        string Engine { get; set; } = string.Empty;
        uint Price { get; set; }

        public Vehicle(string model, string brand, DateOnly date, ushort power, string engine, uint price, ushort speed)
        {
            this.Model = model;
            this.Brand = brand;
            this.Date = date;
            this.Power = power;
            this.Engine = engine;
            this.Price = price;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"Model: {this.Model}\nBrand: {this.Brand}\nDate: {this.Date}\nPower: {this.Power}\nEngine: {this.Engine}\nPrice: {this.Price}\nSpeed: {this.Speed}";
        }

        public void Test()
        {

        }
    }
}
