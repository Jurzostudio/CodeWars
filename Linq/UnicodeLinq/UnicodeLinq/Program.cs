using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniTotal(""));
            Console.WriteLine(UniTotal("a"));
            Console.WriteLine(UniTotal("aaa"));
            Console.WriteLine(UniTotal("Mary Had A Little Lamb"));
            Console.ReadKey();
        }
        public static int UniTotal(string str)
        {   
            return str.Sum(x => Convert.ToInt32(x));
        }
    }
}
