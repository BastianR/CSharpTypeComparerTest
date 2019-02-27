using StringCompare.Enums;
using StringCompare.Models;
using System;

namespace StringCompare.Services
{
    public static class ModelGenerator
    {
        #region Fields

        private static Random _random;
        private static string _possibleChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";

        #endregion



        #region Constructor

        static ModelGenerator()
        {
            _random = new Random();
        }

        #endregion



        #region Public Methods

        public static TestModel GenerateTestModel(int id)
        {
            return new TestModel
            {
                Id = id,
                TestByte = GenerateByte(),
                TestSbyte = GenerateSbyte(),
                TestShort = GenerateShort(),
                TestUshort = GenerateUshort(),
                TestInt = GenerateInt(),
                TestUint = GenerateUint(),
                TestLong = GenerateLong(),
                TestUlong = GenerateUlong(),
                TestFloat = GenerateFloat(),
                TestDouble = GenerateDouble(),
                TestDecimal = GenerateDecimal(),
                TestChar = GenerateChar(),
                TestBool = GenerateBool(),
                TestString = GenerateString(),
                TestDateTime = GenerateDateTime(),
                TestEnum = GenerateTestEnum()
            };
        }

        #endregion



        #region Private Methods

        private static byte GenerateByte()
        {
            return Convert.ToByte(_random.Next(0, 255));
        }

        private static sbyte GenerateSbyte()
        {
            return Convert.ToSByte(_random.Next(-128, 127));
        }

        private static short GenerateShort()
        {
            return Convert.ToInt16(_random.Next(-32768, 32767));
        }

        private static ushort GenerateUshort()
        {
            return Convert.ToUInt16(_random.Next(0, 65535));
        }

        private static int GenerateInt()
        {
            return Convert.ToInt32(_random.Next(-2147483648, 2147483647));
        }

        private static uint GenerateUint()
        {
            return (uint)(_random.Next(1 << 30)) << 2 | (uint)(_random.Next(1 << 2));
        }

        private static long GenerateLong()
        {
            int randomInt1 = _random.Next(-2147483648, 2147483647);
            int randomInt2 = _random.Next(-2147483648, 2147483647);

            return randomInt1 * randomInt2;
        }

        private static ulong GenerateUlong()
        {
            uint randomUint1 = (uint)(_random.Next(1 << 30)) << 2 | (uint)(_random.Next(1 << 2));
            uint randomUint2 = (uint)(_random.Next(1 << 30)) << 2 | (uint)(_random.Next(1 << 2));

            return randomUint1 * randomUint2;
        }

        private static float GenerateFloat()
        {
            return (float)_random.NextDouble();
        }

        private static double GenerateDouble()
        {
            return _random.NextDouble();
        }

        private static decimal GenerateDecimal()
        {
            return (decimal)(_random.NextDouble() * _random.NextDouble());
        }

        private static char GenerateChar()
        {
            return _possibleChars[_random.Next(0, _possibleChars.Length)];
        }

        private static bool GenerateBool()
        {
            return _random.Next(0, 1) == 0 ? false : true;
        }

        private static string GenerateString()
        {
            string concatedString = "";
            for (int i = 0; i < _random.Next(7, 15); i++)
            {
                concatedString += GenerateChar();
            }
            return concatedString;
        }

        private static DateTime GenerateDateTime()
        {
            return DateTime.Now;
        }

        private static TestEnum GenerateTestEnum()
        {
            Array values = Enum.GetValues(typeof(TestEnum));
            return (TestEnum)values.GetValue(_random.Next(values.Length));
        }

        #endregion
    }
}
