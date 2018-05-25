using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Word1", "Word1", "Word2", "Word2", "Word2" };
            foreach (var i in Count(list))
                Console.WriteLine(i.Key.ToString() + "---" + i.Value.ToString());
            Console.ReadKey();
        }
        public static Dictionary<string, int> Count(List<string> lst)
        {
            return lst.GroupBy(x => x).Select(v => new { Key = v.First().ToString(), Value = v.Count() }).ToDictionary(t => t.Key, t => t.Value);               
        }
    }
}
