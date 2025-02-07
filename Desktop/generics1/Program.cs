using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Intvalue = new Box<int>();
            Intvalue.SetValue(95);

            Console.WriteLine(Intvalue.GetValue());

            var Stringvalue = new Box<string>();
            Stringvalue.SetValue("Hello World");
            Console.WriteLine(Stringvalue.GetValue());

            List<string> ListString = new List<string>(); 
            ListString.Add("Maaz");
            ListString.Add("Shayan");
            ListString.Add("Qadir");
            ListString.Add("Hasnain");

            Console.WriteLine(ListString[0]);




            Console.ReadLine(); 

        }
    }
}
