using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Patterns3.Strategy;

namespace Patterns3
{
    abstract class SomeMatrix : IMatrix
    {
        private readonly int row, col;
        private IVector[] matr;
        private IStrategy strategy;

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

        public void Draw(IDrawer drawer, bool flag)
        {
            DrawFrame(drawer, flag);
            DrawCells(drawer);
            DrawMatrix(drawer);
        }

        protected void DrawFrame(IDrawer drawer, bool flag)
        {
            if (flag)
            {
                drawer.DrawFrame(this);
            }
        }

        protected void DrawCells(IDrawer drawer)
        {
            for (int i = 0; i < this.Row_count; i++)
            {
                for (int j = 0; j < this.Column_count; j++)
                {
                    drawer.DrawCell(this, i, j);
                }
            }
        }

        protected void DrawMatrix(IDrawer drawer)
        {
            drawer.DrawMatrix(this);
        }

        protected abstract IVector Create(int co);
      
        public virtual int Row_count { get { return row; } }
        public virtual int Column_count { get { return col; } }

        public IStrategy Strategy { get => strategy; set => strategy = value; }

        public virtual void SetValue(double chisl, int i, int j)
        {
            matr[j].SetValue(i, chisl);
        }

        public virtual double GetValue(int i, int j)
        {
            return matr[j].GetValue(i);
        }
    }
}
