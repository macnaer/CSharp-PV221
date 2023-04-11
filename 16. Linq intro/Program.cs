// LINQ (Language-Integrated Query) // 
/*Существует несколько разновидностей LINQ: 
LINQ to Objects: применяется для работы с массивами и коллекциями LINQ to Entities: используется при обращении к базам данных через технологию Entity Framework LINQ to Sql: технология доступа к данным в MS SQL Server LINQ to XML: применяется при работе с файлами XML LINQ to DataSet: применяется при работе с объектом DataSet Parallel LINQ (PLINQ): используется для выполнения параллельной запросов */ // Список используемых методов расширения LINQ
/*
Select: определяет проекцию выбранных значений 
Where: определяет фильтр выборки
OrderBy: упорядочивает элементы по возрастанию 
OrderByDescending: упорядочивает элементы по убыванию 
ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию 
ThenByDescending: задает дополнительные критерии для упорядочивания элементов по убыванию 
Join: соединяет две коллекции по определенному признаку 
GroupBy: группирует элементы по ключу 
ToLookup: группирует элементы по ключу, при этом все элементы добавляются в словарь 
GroupJoin: выполняет одновременно соединение коллекций и группировку элементов по ключу 
Reverse: располагает элементы в обратном порядке 
All: определяет, все ли элементы коллекции удовлятворяют определенному условию 
Any: определяет, удовлетворяет хотя бы один элемент коллекции определенному условию 
Contains: определяет, содержит ли коллекция определенный элемент 
Distinct: удаляет дублирующиеся элементы из коллекции 
Except: возвращает разность двух коллекцию, то есть те элементы, которые содератся только в одной коллекции 
Union: объединяет две однородные коллекции 
Intersect: возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях 
Count: подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию 
Sum: подсчитывает сумму числовых значений в коллекции 
Average: подсчитывает cреднее значение числовых значений в коллекции 
Min: находит минимальное значение Max: находит максимальное значение 
Take: выбирает определенное количество элементов 
Skip: пропускает определенное количество элементов 
TakeWhile: возвращает цепочку элементов последовательности, до тех пор, пока условие истинно 
SkipWhile: пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы 
Concat: объединяет две коллекции Zip: объединяет две коллекции в соответствии с определенным условием 
First: выбирает первый элемент коллекции 
FirstOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию 
Single: выбирает единственный элемент коллекции, если коллекция содердит больше или меньше одного элемента, то генерируется исключение 
SingleOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию 
ElementAt: выбирает элемент последовательности по определенному индексу 
ElementAtOrDefault: выбирает элемент коллекции по определенному индексу или возвращает значение по умолчанию, если индекс вне допустимого диапазона 
Last: выбирает последний элемент коллекции 
LastOrDefault: выбирает последний элемент коллекции или возвращает значение по умолчанию */
namespace _16._Linq_intro
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*int[] arrayInt = { 5, 34, 67, -12, 94, -42 };

            IEnumerable<int> query = from item in arrayInt
                                     select item * -1;
            foreach (int item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============select=======================");
            var result = arrayInt.Select(n => n * -1);
           
            foreach (int item2 in result)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("==============select=======================");
            Console.WriteLine("==============where========================");
            var wResult = from item in arrayInt
                          where item % 2 == 0
                          select item;
            foreach (int item2 in wResult)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("==============where========================");

            string[] fruits = {"Apple", "Cherry", "Banana", "Mango", "Orange", "Lemon" };
            //var resFruits = from fruit in fruits
            //             where fruit.Length == 5
            //             select fruit;
            var resFruits = fruits.Where(f => f.Length == 5);

            foreach (var item2 in resFruits)
            {
                Console.WriteLine(item2);
            }

            Console.WriteLine("==============orderBy========================");
            //IEnumerable<int> orderByResult = from item in arrayInt
            //                                 where item % 2 == 0
            //                                 orderby Math.Abs(item) ascending
            //                                 select item;
            var orderByResult = arrayInt.Where(i => i % 2 == 0).OrderByDescending(i => Math.Abs(i));


            foreach (var item in orderByResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============groupBy========================");
            IEnumerable<IGrouping<int, int>> grupByResult = from item in arrayInt
                                                            where item > 10
                                                            group item by item % 10;

            foreach (IGrouping<int, int> item in grupByResult)
            {
                Console.Write($"Key: {item.Key} => Value:");
                foreach(int i in item)
                {
                    Console.WriteLine($" {i}");
                }
            }
            */

            Product[] arr =
            {
                new Product() {Name = "Apple", Category = "Fruits"},
                new Product() {Name = "Phone", Category = "Tech"},
                new Product() {Name = "Laptop", Category = "Tech"},
                new Product() {Name = "Milk", Category = "Food"},
                new Product() {Name = "Potato", Category = "Food"},
            };

            var result = arr.GroupBy(p => p.Category);
            foreach(IGrouping<string, Product> group in result)
            {
                Console.WriteLine($"Key: {group.Key}:\t");
                foreach(Product product in group)
                {
                    Console.Write($"Value: {product.Name} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=========================================");

            var res = arr.Where(p => char.IsUpper(p.Name[0])).Select(p => p.Name[0]);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }

    }
}