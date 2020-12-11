using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Strategy
{
    class SimplMatrixStrategy : IStrategy
    {

        public string GetCell(IMatrix matrix, int i, int j)
        {
            return String.Format("{0,-4:00.00}", matrix.GetValue(i, j));
        }
    }
}
