using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SP2019
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintToScreen();
        }

        //make custom method
        //setting access modifier to public
        public static void PrintToScreen()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
