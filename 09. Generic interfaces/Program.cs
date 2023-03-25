namespace _09._Generic_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            Console.WriteLine("============Show all students");
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("============After sort students by name");
            auditory.Sort();
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("============After sort students by birthday");
            auditory.Sort(new BirthDateComarer());
            foreach (Student student in auditory)
            {
                Console.WriteLine(student);
            }


        }
    }
}