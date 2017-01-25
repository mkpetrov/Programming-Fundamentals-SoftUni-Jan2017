using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = 24;
            var courses = (int)Math.Ceiling((double)persons / capacity);
            Console.WriteLine(courses);
        }
    }
}
