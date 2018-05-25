using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] arr = new Object[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach(var i in RemoveEveryOther(arr))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((value, index) => index % 2 == 0).ToArray();
        }
    }
}
