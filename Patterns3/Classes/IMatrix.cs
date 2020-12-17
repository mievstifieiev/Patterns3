using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Draw;
using Patterns3.Strategy;

namespace Patterns3
{
    interface IMatrix
    {
        public int Row_count { get; }
        public int Column_count { get; }
        public IStrategy Strategy { get; set; }
        public double GetValue(int i, int j);                          //отдает значение матрицы
        public void SetValue(double chisl, int i, int j);                 //записывает значение
        public void Draw(IDrawer drawer); //флаг не нужен в интерфейсе верхнего уровня
    }
}
