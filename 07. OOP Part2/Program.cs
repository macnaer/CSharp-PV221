namespace _07._OOP_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Calc calc;
            //calc.X = 10;
            //calc.Y = 10;
            //calc.Print();

            //Calc calc2;
            //calc2.X = 5;
            //calc2.Y = 5;
            //calc2.Print();
            //Console.WriteLine("====================");
            //calc = calc2;
            //calc.Print();
            //calc2.Print();
            //Console.WriteLine("=======Struct=============");

            //CalcClass calcClass = new CalcClass(20, 20);
            //calcClass.X = 20;
            //calcClass.Y = 20;
            //calcClass.Print();


            //CalcClass calcClass2 = new CalcClass(30, 30);
            //calcClass2.X = 30;
            //calcClass2.Y = 30;
            //calcClass2.Print();
            //Console.WriteLine("====================");
            //calcClass = calcClass2;
            //calcClass.Print();
            //calcClass2.Print();
            //Console.WriteLine("=======Class=============");

            int result;

            CalcClass calc = new CalcClass();
            //calc.Multiply(2, 2, in result);
            //calc.Multiply(4, 6, out result);
            calc.Multiply(4, 6, ref result);
            Console.WriteLine($"Result = {result}");
            //CalcClass calc2 = new CalcClass();
            //Console.WriteLine(CalcClass.Plus(1, 2, 3, 4, 10));
            //Console.WriteLine(CalcClass.counter);
                

        }
    }
}