using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deneme");

            MyDictonary<int, string> dict = new MyDictonary<int, string>();

            dict.Add(1, "EMRE");
            dict.Add(2, "BARAN");
            dict.Add(3, "BULAK");

            Console.WriteLine(dict.Count);


            Console.ReadLine();
        }
    }
}
