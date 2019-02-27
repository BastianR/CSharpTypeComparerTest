using StringCompare.Enums;
using System;

namespace StringCompare.Models
{
    public class TestModel
    {
        #region Properties

        public int Id { get; set; }
        public byte TestByte { get; set; }
        public sbyte TestSbyte { get; set; }
        public short TestShort { get; set; }
        public ushort TestUshort { get; set; }
        public int TestInt { get; set; }
        public uint TestUint { get; set; }
        public long TestLong { get; set; }
        public ulong TestUlong { get; set; }
        public float TestFloat { get; set; }
        public double TestDouble { get; set; }
        public decimal TestDecimal { get; set; }
        public char TestChar { get; set; }
        public bool TestBool { get; set; }
        public string TestString { get; set; }
        public DateTime TestDateTime { get; set; }
        public TestEnum TestEnum { get; set; }

        #endregion
    }
}
