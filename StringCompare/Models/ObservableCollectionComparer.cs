using StringCompare.Enums;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace StringCompare.Models
{
    public class ObservableCollectionComparer
    {
        #region Fields

        private ObservableCollection<TestModel> _testModels;

        #endregion



        #region Constructor

        public ObservableCollectionComparer(ObservableCollection<TestModel> testModels)
        {
            _testModels = testModels;
            TestResult = new TestResult(TypeOfTest.ObserableCollection);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            TestResult.Results.Add("Byte", CompareBytes());
            Console.Write(".");
            TestResult.Results.Add("SByte", CompareSbytes());
            Console.Write(".");
            TestResult.Results.Add("Short", CompareShorts());
            Console.Write(".");
            TestResult.Results.Add("UShort", CompareUshorts());
            Console.Write(".");
            TestResult.Results.Add("Int", CompareInts());
            Console.Write(".");
            TestResult.Results.Add("UInt", CompareUints());
            Console.Write(".");
            TestResult.Results.Add("Long", CompareLongs());
            Console.Write(".");
            TestResult.Results.Add("ULong", CompareUlongs());
            Console.Write(".");
            TestResult.Results.Add("Float", CompareFloats());
            Console.Write(".");
            TestResult.Results.Add("Double", CompareDoubles());
            Console.Write(".");
            TestResult.Results.Add("Decimal", CompareDecimals());
            Console.Write(".");
            TestResult.Results.Add("Char", CompareChars());
            Console.Write(".");
            TestResult.Results.Add("Bool", CompareBools());
            Console.Write(".");
            TestResult.Results.Add("String", CompareStrings());
            Console.Write(".");
            TestResult.Results.Add("DateTime", CompareDateTimes());
            Console.Write(".");
            TestResult.Results.Add("Enum", CompareEnums());
            Console.WriteLine(".");

            stopwatch.Stop();
            TestResult.Results.Add("AllTimeElapsed", stopwatch.ElapsedMilliseconds);
        }

        #endregion



        #region Properties

        public TestResult TestResult { get; }

        #endregion



        #region Private Methods

        private long CompareBytes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestByte == _testModels[j].TestByte)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareSbytes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestSbyte == _testModels[j].TestSbyte)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareShorts()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestShort == _testModels[j].TestShort)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareUshorts()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestUshort == _testModels[j].TestUshort)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareInts()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestInt == _testModels[j].TestInt)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareUints()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestUint == _testModels[j].TestUint)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareLongs()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestLong == _testModels[j].TestLong)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareUlongs()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestUlong == _testModels[j].TestUlong)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareFloats()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestFloat == _testModels[j].TestFloat)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareDoubles()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestDouble == _testModels[j].TestDouble)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareDecimals()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestDecimal == _testModels[j].TestDecimal)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareChars()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestChar == _testModels[j].TestChar)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareBools()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestBool == _testModels[j].TestBool)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareStrings()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestString == _testModels[j].TestString)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareDateTimes()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestDateTime == _testModels[j].TestDateTime)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private long CompareEnums()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < Math.Pow(_testModels.Count, 3); i++)
            {
                for (int j = 0; j < _testModels.Count; j++)
                {
                    if (_testModels[0].TestEnum == _testModels[j].TestEnum)
                    {
                        int a = 1 + 2;
                    }
                    else
                    {
                        int b = 3 + 4;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        #endregion
    }
}
