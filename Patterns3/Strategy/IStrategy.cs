using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Decorator;
using Patterns3.Draw;

namespace Patterns3.Strategy
{
    interface IStrategy
    {
        string GetCell(IMatrix matrix, int i, int j);
    }
}
