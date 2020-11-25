using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Draw;

namespace Patterns3
{
    interface IMatrix
    {
        public int Row_count { get; }
        public int Column_count { get; }
        IMatrix Matrix { get; }

        public double GetValue(int i, int j);                          //отдает значение матрицы
        public void SetValue(double chisl, int i, int j);                 //записывает значение
        public void Draw(IDrawer drawer, bool flag);
    }
}
