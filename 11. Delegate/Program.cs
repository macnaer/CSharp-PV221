namespace _11._Delegate
{
    internal class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.RegisterOnTFast(ToPastHandler);
            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }
        }

        private static void ToPastHandler()
        {
            Console.WriteLine($"To fast! You must breack.");
            car.Breack();
        }
    }
}