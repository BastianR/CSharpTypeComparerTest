using StringCompare.Models;
using StringCompare.Services;
using System;

namespace StringCompare
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Prepare tester and models ...
            TheTester theTester = new TheTester(100);
            theTester.FillLists();

            // Run the tests ...
            theTester.TestSingleThreaded();
            theTester.TestSingleExtraThreaded();
            theTester.TestMultiThreaded();

            // Create csv file ...
            CsvCreator.CreateCsvFile(theTester.AllTestResults);

            // Take a breath and see the results ...
            Console.ReadKey();
        }
    }
}
