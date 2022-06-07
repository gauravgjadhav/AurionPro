using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class LoopTest
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Using While Loop:Gaurav Jadhav ");
                i++;
            }
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Using For Loop :Gaurav Jadhav ");
            }
        }
    }
}
