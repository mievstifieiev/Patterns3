using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3
{
    interface IVector
    {
        public int Size { get; }
        public double GetValue(int i);           //отдает i-ое значение вектора
        public void SetValue(int h, double chislo);

    }
}
