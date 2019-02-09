using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(1, "Jan");
            Person person2 = new Person(2, "Tomek", "Kowalski");
            Person person3 = new Person(3, "Krzysiek", "Nowak", "Koszalin", 30, "mężczyzna");
        }
    }
}
