using System.Text;

namespace _17._Lonq_Countinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>
            {
                new Group { Id = 1, Name = "PV221"},
                new Group { Id = 2, Name = "PD112" }
            };

            List<Student> students = new List<Student>()
            {
                new Student { FirstName = "Edward", Surname = "Snowden", GroupId = 1 },
                new Student { FirstName = "Eva", Surname = "Barton", GroupId = 2},
                new Student { FirstName = "Samanta", Surname = "Rodriges", GroupId = 2},
                new Student { FirstName = "Linus", Surname = "Torvalds", GroupId = 1},
                new Student { FirstName = "Richard", Surname = "Stolman", GroupId = 1},
            };

            //foreach(var group in groups)
            //{
            //    foreach(var student in students)
            //    {
            //        if(group.Id == student.GroupId)
            //        {
            //            var result = new
            //            {
            //                group.Name,
            //                student.FirstName,
            //                student.Surname,
            //            };

            //            Console.WriteLine(result);
            //        }
            //    }
            //}

            //var query = from g in groups
            //            join student in students on g.Id equals student.GroupId
            //            select new { FirstName = student.FirstName, Lastname = student.Surname, GroupName = g.Name };

            //foreach( var student in query )
            //{
            //    Console.WriteLine($"Name: {student.FirstName}\nSurname: {student.Lastname}\nGroupName: {student.GroupName}\n============================");
            //}

            Console.WriteLine("-------------------------------------");

            //var res = groups.Join(students, g => g.Id, st => st.GroupId, (g,st) => new { FirstName = st.FirstName, Lastname = st.Surname, GroupName = g.Name });

            //foreach (var student in res)
            //{
            //    Console.WriteLine($"Name: {student.FirstName}\nSurname: {student.Lastname}\nGroupName: {student.GroupName}\n============================");
            //}
            const double daysOfYer = 365.25;

            List<Student> students1 = new List<Student>
            {
                new Student { FirstName = "Emma", Surname = "Anderson", BirthDate = new DateTime(2001, 4, 13), GroupId = 1 },
                new Student { FirstName = "Tim", Surname = "Berns Lee", BirthDate = new DateTime(1999, 12, 23), GroupId = 1 },
                new Student { FirstName = "Camilla", Surname = "Terry", BirthDate = new DateTime(2004, 10, 3), GroupId = 2 },
                new Student { FirstName = "Robin", Surname = "Van der mate", BirthDate = new DateTime(2000, 1, 1), GroupId = 2 },
            };

            Console.WriteLine($"Current date: {DateTime.Now.ToLongDateString()}");

            //var olderThen24 = from item in students1
            //                  where (DateTime.Now - item.BirthDate).Days / daysOfYer > 24
            //                  select item;

            //foreach( var student in olderThen24)
            //{
            //    Console.WriteLine(student);
            //}

            var olderThen24 = students1.Where(s => (DateTime.Now - s.BirthDate).Days / daysOfYer > 20);
            foreach (var student in olderThen24)
            {
                Console.WriteLine(student);
            }

            var maxDate = students1.Max(s => s.BirthDate);

            var 

            
        }
    }
}