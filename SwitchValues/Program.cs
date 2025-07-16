using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int b=int.Parse(Console.ReadLine());
            switch(a>b)
            {
                case true:
                    Console.WriteLine("a is greater than b");
                    break;
                    case false:
                    Console.WriteLine("a is less than b");
                    break;
                    
            }
        }
    }
}
