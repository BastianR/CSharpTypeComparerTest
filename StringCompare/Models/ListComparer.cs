using StringCompare.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StringCompare.Models
{
    public class ListComparer
    {
        #region Fields

        private List<TestModel> _testModels;
        private TestResult _testResult;

        #endregion



        #region Constructor

        public ListComparer(List<TestModel> testModels)
        {
            _testModels = testModels;
            _testResult = new TestResult(TypeOfTest.List);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            _testResult.Results.Add("Byte", CompareBytes());
            _testResult.Results.Add("SByte", CompareSbytes());
            _testResult.Results.Add("Short", CompareShorts());
            _testResult.Results.Add("UShort", CompareUshorts());
            _testResult.Results.Add("Int", CompareInts());
            _testResult.Results.Add("UInt", CompareUints());
            _testResult.Results.Add("Long", CompareLongs());
            _testResult.Results.Add("ULong", CompareUlongs());
            _testResult.Results.Add("Float", CompareFloats());
            _testResult.Results.Add("Double", CompareDoubles());
            _testResult.Results.Add("Decimal", CompareDecimals());
            _testResult.Results.Add("Char", CompareChars());
            _testResult.Results.Add("Bool", CompareBools());
            _testResult.Results.Add("String", CompareStrings());
            _testResult.Results.Add("DateTime", CompareDateTimes());
            _testResult.Results.Add("Enum", CompareEnums());

            stopwatch.Stop();
            _testResult.Results.Add("AllTimeElapsed_List", stopwatch.ElapsedMilliseconds);
        }

        #endregion



        #region Properties

        public TestResult TestResult
        {
            get => _testResult;
        }

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
