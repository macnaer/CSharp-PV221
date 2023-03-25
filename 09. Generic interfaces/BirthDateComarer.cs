using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Generic_interfaces
{
    internal class BirthDateComarer : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return a.BirthDate.CompareTo(b.BirthDate);
        }

    }
}
