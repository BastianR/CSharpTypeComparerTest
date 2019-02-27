using StringCompare.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace StringCompare.Services
{
    public static class CsvCreator
    {
        #region Constructor

        public static void CreateCsvFile(Dictionary<string, TestResult> testResults)
        {
            System.Console.WriteLine("Collect TestResults for Csv file");

            StringBuilder stringBuilder = new StringBuilder();

            AppendHeader(stringBuilder);

            TestResult singleThreadedArray = testResults["SingleThreaded_Array"];
            AppendStringBuilderLine(stringBuilder, singleThreadedArray, "Single Threaded Array");
            TestResult singleThreadedList = testResults["SingleThreaded_List"];
            AppendStringBuilderLine(stringBuilder, singleThreadedList, "Single Threaded List");
            TestResult singleThreadedDictionary = testResults["SingleThreaded_Dictionary"];
            AppendStringBuilderLine(stringBuilder, singleThreadedDictionary, "Single Threaded Dictionary");
            TestResult singleThreadedObservableCollection = testResults["SingleThreaded_ObservableCollection"];
            AppendStringBuilderLine(stringBuilder, singleThreadedObservableCollection, "Single Threaded ObservableCollection");

            TestResult testSingleExtraThreadedArray = testResults["TestSingleExtraThreaded_Array"];
            AppendStringBuilderLine(stringBuilder, testSingleExtraThreadedArray, "Single Task Threaded Array");
            TestResult testSingleExtraThreadedList = testResults["TestSingleExtraThreaded_List"];
            AppendStringBuilderLine(stringBuilder, testSingleExtraThreadedList, "Single Task Threaded List");
            TestResult testSingleExtraThreadedDictionary = testResults["TestSingleExtraThreaded_Dictionary"];
            AppendStringBuilderLine(stringBuilder, testSingleExtraThreadedDictionary, "Single Task Threaded Dictionary");
            TestResult testSingleExtraThreadedObservableCollection = testResults["TestSingleExtraThreaded_ObservableCollection"];
            AppendStringBuilderLine(stringBuilder, testSingleExtraThreadedObservableCollection, "Single Task Threaded ObservableCollection");

            TestResult testMultiThreadedArray = testResults["TestMultiThreaded_Array"];
            AppendStringBuilderLine(stringBuilder, testMultiThreadedArray, "Multi Task Threaded Array");
            TestResult testMultiThreadedList = testResults["TestMultiThreaded_List"];
            AppendStringBuilderLine(stringBuilder, testMultiThreadedList, "Multi Task Threaded List");
            TestResult testMultiThreadedDictionary = testResults["TestMultiThreaded_Dictionary"];
            AppendStringBuilderLine(stringBuilder, testMultiThreadedDictionary, "Multi Task Threaded Dictionary");
            TestResult testMultiThreadedObservableCollection = testResults["TestMultiThreaded_ObservableCollection"];
            AppendStringBuilderLine(stringBuilder, testMultiThreadedObservableCollection, "Multi Task Threaded ObservableCollection");

            System.Console.WriteLine("Create TestResult Csv file");
            SaveCsvFile(stringBuilder);
        }

        #endregion



        #region Private Methods

        private static void AppendHeader(StringBuilder stringBuilder)
        {
            stringBuilder.Append("Test");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Byte");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("SByte");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Short");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("UShort");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Int");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("UInt");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Long");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("ULong");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Float");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Double");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Decimal");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Char");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Bool");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("String");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("DateTime");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("Enum");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append("AllTimeElapsed");
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.AppendLine();
        }

        private static void AppendStringBuilderLine(StringBuilder stringBuilder, TestResult testResult, string testName)
        {
            stringBuilder.Append(testName);
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Byte"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["SByte"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Short"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["UShort"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Int"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["UInt"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Long"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["ULong"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Float"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Double"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Decimal"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Char"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Bool"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["String"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["DateTime"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["Enum"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.Append(testResult.Results["AllTimeElapsed"].ToString());
            stringBuilder.Append(CultureInfo.CurrentCulture.TextInfo.ListSeparator);
            stringBuilder.AppendLine();
        }

        private static void SaveCsvFile(StringBuilder stringBuilder)
        {
            string filePath = "D:\\TestResult.csv";
            File.AppendAllText(filePath, stringBuilder.ToString());

            System.Console.WriteLine($"File created in {filePath}");
        }

        #endregion
    }
}
