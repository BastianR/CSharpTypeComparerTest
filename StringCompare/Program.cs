using StringCompare.Models;
using System;

namespace StringCompare
{
    static class Program
    {
        static void Main(string[] args)
        {
            TheTester theTester = new TheTester(100);
            theTester.FillLists();
            theTester.TestSingleThreaded();
            theTester.TestSingleExtraThreaded();
            theTester.TestMultiThreaded();

            // Take a breath and see the results ...!
            Console.ReadKey();
        }
    }
}
