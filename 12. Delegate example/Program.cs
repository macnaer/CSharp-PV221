namespace _12._Delegate_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExchangeMonitor exchangeMonitor = new ExchangeMonitor();
            exchangeMonitor.priceExchange = ShowPBPrice;
            exchangeMonitor.priceExchange += ShowMonoPrice;
            exchangeMonitor.priceExchange -= ShowPBPrice;
            exchangeMonitor.Start();

        }

        public static void ShowPBPrice(int price)
        {
            Console.WriteLine($"Current price in PrivatBank: {price}");
        }

        public static void ShowMonoPrice(int price)
        {
            Console.WriteLine($"Current price in Mono Bank: {price}");
        }
    }
}