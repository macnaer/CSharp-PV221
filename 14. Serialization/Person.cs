using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Serialization
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        [NonSerialized]
        public string Position = "Student";

        public override string ToString()
        {
            return $"Id: {this.Id}\nName: {this.Name}\nAge: {this.Age}\nPosition: {this.Position}\n--------------------";
        }
    }
}
