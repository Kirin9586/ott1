using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tuoi, namsinh = 1998;
            String ten = "Ho Anh Tuan";
            Console.Write("Hello nhoc {0}\n", ten);
            tuoi = 2018 - namsinh;
            Console.WriteLine("Tuoi {0}", tuoi);
            Console.ReadKey();



        }
    }
}
