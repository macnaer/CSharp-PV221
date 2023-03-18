namespace _06_OOP_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person bill = new Person("Bill", "Adams", 21);    
            //bill.Print();

            Emploee tom = new Emploee("Tommas", "Anderson", 23, ".Net Developer", 1000);
            //tom.Print();
            tom.SaveCV("Senior ASP.NET Core", 3000);
        }
    }
}