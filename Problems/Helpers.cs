using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Helpers
    {
        public static void PrintList<T>(IList<T> list)
        {
            foreach(T element in list)
                Console.WriteLine(element);
        }
    }
}
