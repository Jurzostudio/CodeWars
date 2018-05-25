using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[]{ 1, 3, 54, 6, 7, 1, 2, 3, 4, 5, 2, 1, 2, 1 };
            Console.WriteLine(find_it(list));
            Console.ReadKey();
        }
        public static int find_it(int[] seq)
        {            
            return seq.GroupBy(x => x).Select(v => new { Value = v.First(), Count = v.Count()}).Select(x=>x).Where((value, count) => count% 2 == 0).Select(x=>x.Value).First();
        }
    }
}
