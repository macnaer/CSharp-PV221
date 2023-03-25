using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Generic_interfaces
{
    internal class Student : IComparable<Student>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(Student? other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {BirthDate.ToLongDateString()}";
        }

    }
}
