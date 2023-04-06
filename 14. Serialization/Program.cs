using System.Text.Json;

namespace _14._Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>()
            {
                new Person() {Id = 1, Name = "Bogdan", Age = 15, Position = "Student"},
                new Person() {Id = 2, Name = "Emma", Age = 19, Position = "Trainee"},
                new Person() {Id = 3, Name = "Bob", Age = 21, Position = "Developer"},
            };

            try
            {
                // Serialize
                string fileName = "Person.json";
                string serializedList = JsonSerializer.Serialize(personList);
                File.WriteAllText(fileName, serializedList);

                //Deserialize
                string deserializedList = File.ReadAllText(fileName);
                List<Person> list = JsonSerializer.Deserialize<List<Person>>(deserializedList);
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }
    }
}