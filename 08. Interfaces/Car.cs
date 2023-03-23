using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Interfaces
{
    internal class Car : IVehicle, IDocument
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateOnly Date { get; set; }
        public ushort Power { get; set; }
        public ushort Speed { get; set; }
        public string Engine { get; set; }
        public uint Price { get; set; }
        public string TechPassport { get; set; }

        public Car(string model, string brand, DateOnly date, ushort power, string engine, uint price, ushort speed, string techPassport)
        {
            this.Model = model;
            this.Brand = brand;
            this.Date = date;
            this.Power = power;
            this.Engine = engine;
            this.Price = price;
            this.Speed = speed;
            this.TechPassport = techPassport;
        }

        public void Print()
        {
            Console.WriteLine($"Model: {this.Model}\nBrand: {this.Brand}\nDate: {this.Date}\nPower: {this.Power}\nEngine: {this.Engine}\nPrice: {this.Price}\nSpeed: {this.Speed}");
        }

        public void PrintDocs()
        {
            Console.WriteLine($"S/N: {this.TechPassport}");
        }
    }
}
