using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Generic_interfaces
{
    internal class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"Student card: {Series} {Number}";
        }
    }
}
