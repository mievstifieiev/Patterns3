using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Patterns3
{
    class SimpleMatrix: SomeMatrix
    {
        public SimpleMatrix(int r, int c) : base(r, c)
        {
            
        }

        protected override IVector Create(int co)
        {
            return new SimpleVector(co);
        }
    }
}
