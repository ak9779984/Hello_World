using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchAndDevelopment
{
    class SampleDelegate
    {
        public delegate int MathOperations(int a, int b);
        //public MathOperations myMathDelegate = null;

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public MathOperations GetAddorSubDelegate(bool isAddDelegate)
        {
            MathOperations obj = null;

            if (isAddDelegate)
            {
                return obj = Add;
            }
            else
            {
                return obj = Sub;
            }
        }
    }
}
