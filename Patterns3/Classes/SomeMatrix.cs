using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Patterns3
{
    abstract class SomeMatrix : IMatrix
    {
        private int row, col;
        private IVector[] matr;

        public void Draw(IDrawer drawer, bool flag)
        {
            for (int i = 0; i < row_count; i++)
            {
                if (flag)
                {
                    drawer.DrawFrame(row_count);
                    drawer.DrawGorFrame();
                }
                else
                {
                    drawer.DrawFrame(0);
                }
                for (int j = 0; j < column_count; j++)
                {
                    drawer.DrawCell(this.GetValue(i, j), this);
                }
                if (flag)
                {
                    drawer.DrawGorFrame();
                }
            }
            if (flag)
            {
                drawer.DrawFrame(row_count);
            }
            else
            {
                drawer.DrawFrame(0);
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

        public void Print()
        {
            Console.WriteLine("______________________");
            foreach (var item in matr)
            {
                Console.Write("|");
                for (int i=0; i<item.Size; i++)
                {
                    Console.Write("{0,2:00}  ", item.GetValue(i));
                    
                }
                Console.Write("|\n");
            }
            Console.WriteLine("______________________");
        }

        public IVector this[int index]
        {
            get { return matr[index]; }
        }
    }
}
