namespace _13._Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Keyboard keyboard = new Keyboard();
            keyboard.PressKeyA += new PressKeyEventHandler(PressKeyA_Handler);
            keyboard.PressKeyE += PressKeyE_Handler;

            keyboard.Start();
        }

        static private void PressKeyA_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("   *    ");
            Console.WriteLine("  * *   ");
            Console.WriteLine(" * * *  ");
            Console.WriteLine("*     * ");

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static private void PressKeyE_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("****");
            Console.WriteLine("*   ");
            Console.WriteLine("****");
            Console.WriteLine("*   ");
            Console.WriteLine("****");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}