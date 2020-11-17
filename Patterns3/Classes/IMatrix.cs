using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3
{
    interface IMatrix
    {
        public int row_count { get; }
        public int column_count { get; }
        public double GetValue(int i, int j);                          //отдает значение матрицы
        public void SetValue(double chisl, int i, int j);                 //записывает значение
    }
}
