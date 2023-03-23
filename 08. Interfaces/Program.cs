using System.Globalization;

namespace _08._Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var theDate = new DateOnly(2015, 10, 21);
            Car car = new Car("A6", "Audi", theDate, 250, "Diesel", 15000, 250, "My TechPass");
            car.Print();
            car.PrintDocs();
        }


    }
}