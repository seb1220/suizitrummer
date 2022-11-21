using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTest_Kawicher
{
    internal class AlgoException: Exception
    {
        public AlgoException() { }

        public AlgoException(string message)
            : base(message) { }

        public AlgoException(string message, Exception inner)
            : base(message, inner) { }
    }
}
