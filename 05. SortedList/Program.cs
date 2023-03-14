namespace _05._SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countries = new SortedList<int, string>();
            countries.Add(1, "Ukraine");
            countries.Add(6, "Poland");
            countries.Add(3, "Moldova");

            foreach(var country in countries)
            {
                Console.WriteLine($"{country.Key} => {country.Value}");
            }
        }
    }
}