using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._Lonq_Countinue
{
    internal class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public int GroupId { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {FirstName}, Born: {BirthDate.ToLongDateString()}";
        }
    }
}
