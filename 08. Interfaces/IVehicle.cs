using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Interfaces
{
    internal interface IVehicle
    {
        string Model { get; set; }
        string Brand { get; set; }
        DateOnly Date { get; set; }
        ushort Power { get; set; }
        ushort Speed { get; set; }
        string Engine { get; set; }
        uint Price { get; set; }
        public void Print();
    }
}
