using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Generic_interfaces
{
    internal class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName = "Linus",
                LastName = "Torvalds",
                BirthDate = new DateTime(1978, 7, 11),
                StudentCard = new StudentCard
                {
                    Number = 2342346,
                    Series = "VK2345AC"
                }
            },
             new Student
            {
                FirstName = "Camilla",
                LastName = "Terry",
                BirthDate = new DateTime(1981, 12, 6),
                StudentCard = new StudentCard
                {
                    Number = 9332346,
                    Series = "BC1845AC"
                }
            },
              new Student
            {
                FirstName = "Eva",
                LastName = "Andersen",
                BirthDate = new DateTime(1982, 8, 12),
                StudentCard = new StudentCard
                {
                    Number = 9604839,
                    Series = "AA1234AC"
                }
            }
        };

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
}
