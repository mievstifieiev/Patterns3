using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Draw;

namespace Patterns3.Strategy
{
    class SparseMatrixStrategy:IStrategy
    {
        public string GetCell(IMatrix matrix, int i, int j)
        {
            string cell = "";
            if (matrix.GetValue(i, j) == 0)
            {
                cell += String.Format("{0, -5:00.00}", "");
            }
            else
            {
                cell += String.Format("{0,-4:00.00}", matrix.GetValue(i, j));
            }
            return cell;
        }
    }
}
