using StringCompare.Enums;
using System.Collections.Generic;

namespace StringCompare.Models
{
    public class TestResult
    {
        #region Fields

        private TypeOfTest _typeOfTest;
        private Dictionary<string, long> _results;

        #endregion



        #region Constructor

        public TestResult(TypeOfTest typeOfTest)
        {
            _typeOfTest = typeOfTest;
            _results = new Dictionary<string, long>();
        }

        #endregion



        #region Properties

        public Dictionary<string, long> Results
        {
            get => _results;
        }

        #endregion
    }
}
