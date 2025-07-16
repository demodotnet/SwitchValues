using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchValues
{
    /*
     * Comparision between if else and switch condition
     * Both are executing one option among multiple options
     * Execution wise switch is faster than if else because
     * switch directly branching and if else if is ladder branching.
     * 1.Switch execution wise is faster than if else if but which is 
     * haivng some limitations 
     * 1)expression of swtich cannot be a floating value.
     */
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
