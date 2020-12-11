using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Patterns3.Strategy;

namespace Patterns3
{
    class SimpleMatrix: SomeMatrix
    {
        public SimpleMatrix(int r, int c) : base(r, c)
        {
            Strategy = new SimplMatrixStrategy();
        }


        protected override IVector Create(int co)
        {
            return new SimpleVector(co);
        }
    }
}
