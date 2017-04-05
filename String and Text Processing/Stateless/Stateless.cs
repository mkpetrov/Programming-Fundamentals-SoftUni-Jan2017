using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            var state = Console.ReadLine();
            

            while (state!= "collapse")
            {
                var fiction = Console.ReadLine();

                while (fiction.Length>0)
                {
                    var check = state.IndexOf(fiction);
                    if (check>=0)
                    {
                        state = state.Replace(fiction, "");
                    }
                    fiction = fiction.Remove(0, 1);
                    var fictionLastIndex = fiction.Length - 1;
                    if (fictionLastIndex>=0)
                    {
                        fiction = fiction.Remove(fictionLastIndex, 1);
                    }
                    
                }
                if (state.Length>0)
                {
                    Console.WriteLine(state);
                }
                else
                {
                    Console.WriteLine("(void)");
                }
                state = Console.ReadLine();
            }
        }
    }
}
