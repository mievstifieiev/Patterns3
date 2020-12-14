using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Strategy
{
    class HGMStrategy : IStrategy
    {
        public string GetCell(IMatrix matrix, int i, int j)
        {
            return string.Format("{0, -5:00.00}", "");
        }
    }
}
