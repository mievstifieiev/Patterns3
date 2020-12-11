using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Patterns3.Strategy;

namespace Patterns3
{
    class SparseMatrix: SomeMatrix
    { 
        public SparseMatrix(int r, int c): base(r,c)
        {

            Strategy = new SparseMatrixStrategy();
        }

        protected override IVector Create(int co)
        {
            return new SparseVector(co);
        }
    }
}
