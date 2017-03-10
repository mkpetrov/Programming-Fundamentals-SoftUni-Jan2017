using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Unique_Names
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names= new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var currentName=(Console.ReadLine());
                if (!names.Contains(currentName))
                {
                    names.Add(currentName);
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
