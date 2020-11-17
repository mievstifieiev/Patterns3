using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Patterns3
{
    abstract class SomeMatrix : IMatrix
    {
        private readonly int row, col;
        private IVector[] matr;

        public void Draw(IDrawer drawer, bool flag)
        {
            if (flag)
            {
                drawer.DrawFrame(this);
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    drawer.DrawCell(this, i, j);
                }
            }
            drawer.DrawMatrix();
        }

        public SomeMatrix(int r, int c)
        {
            matr = new IVector[r];
            this.row = r;
            this.col = c;
            for (int i = 0; i < r; i++)
            {
                matr[i] = Create(c);
            }
        }

        protected abstract IVector Create(int co);
      
        public int row_count { get { return row; } }
        public int column_count { get { return col; } }

        public void SetValue(double chisl, int i, int j)
        {
            matr[i].SetValue(j, chisl);
        }

        public double GetValue(int i, int j)
        {
            return (matr[i].GetValue(j));
        }
    }
}
