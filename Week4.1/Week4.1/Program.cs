using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Week4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nBubble Sort:");
            Test.RunTest(Sort.BubbleSort);
            Console.WriteLine("\n\nInsertion Sort:");
            Test.RunTest(Sort.InsertionSort);
            Console.WriteLine("\n\nSelection Sort:");
            Test.RunTest(Sort.SelectionSort);
            Console.WriteLine("\n\nQuicksort:");
            Test.RunTest(Sort.Quicksort);
        }

    }
}
  

 

 