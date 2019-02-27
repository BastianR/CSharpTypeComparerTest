using StringCompare.Enums;
using StringCompare.Models;
using System;
using System.Diagnostics;

namespace StringCompare.Services
{
    public class ArrayComparer
    {
        #region Fields

        private TestModel[] _testModels;

        #endregion



        #region Constructor

        public ArrayComparer(TestModel[] testModels)
        {
            _testModels = testModels;
            TestResult = new TestResult(TypeOfTest.Array);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            TestResult.Results.Add("Byte", CompareBytes());
            TestResult.Results.Add("SByte", CompareSbytes());
            TestResult.Results.Add("Short", CompareShorts());
            TestResult.Results.Add("UShort", CompareUshorts());
            TestResult.Results.Add("Int", CompareInts());
            TestResult.Results.Add("UInt", CompareUints());
            TestResult.Results.Add("Long", CompareLongs());
            TestResult.Results.Add("ULong", CompareUlongs());
            TestResult.Results.Add("Float", CompareFloats());
            TestResult.Results.Add("Double", CompareDoubles());
            TestResult.Results.Add("Decimal", CompareDecimals());
            TestResult.Results.Add("Char", CompareChars());
            TestResult.Results.Add("Bool", CompareBools());
            TestResult.Results.Add("String", CompareStrings());
            TestResult.Results.Add("DateTime", CompareDateTimes());
            TestResult.Results.Add("Enum", CompareEnums());

            stopwatch.Stop();
            TestResult.Results.Add("AllTimeElapsed_Array", stopwatch.ElapsedMilliseconds);
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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

            for (int i = 0; i < Math.Pow(_testModels.Length, 3); i++)
            {
                for (int j = 0; j < _testModels.Length; j++)
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
