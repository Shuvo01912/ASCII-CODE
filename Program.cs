using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSSi_To_Int_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ascii To Int any type of charcher
            Console.WriteLine("Enter Any Char to Get ASCII Code:");
            char c = Convert.ToChar(Console.ReadLine());
            int a = Convert.ToInt32(c);
            Console.WriteLine(a);
        }
    }
}
