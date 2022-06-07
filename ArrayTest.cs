using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            char[] arr = {'G', 'a', 'u', 'a', 'v',
                         'j', 'a', 'd', 'h',
                                 'a', 'v'};
            Console.Write("Array printing using for loop = ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            Console.Write("Array printing using foreach loop = ");
            foreach (char ch in arr)
            {
                Console.Write(ch);
            }       
        }
    }
}
