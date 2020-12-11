using Patterns3.Draw;
using Patterns3.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.HGMatrix
{
    class HGMatrix : IMatrix
    {
        private IMatrix[] matrices;

        public int Row_count
        {
            get
            {
                int size = 0;
                foreach (var item in matrices)
                {
                    size += item.Row_count;
                }
                return size;
            }
        }

        public int Column_count
        {
            get
            {
                int size = 0;
                foreach (var item in matrices)
                {
                    size += item.Column_count;
                }
                return size;
            }
        }

        public IMatrix Matrix => this;

        public IStrategy Strategy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            drawer.DrawMatrix();
        }

        public double GetValue(int i, int j)
        {
            int size = 0, old_size = 0;
            for (int k = 0; k < matrices.Length; k++)
            {
                old_size = size;
                size += matrices[k].Column_count;
                if (size>i)
                {
                    if (matrices[k].Row_count<i)
                    {
                        return 0;
                    }
                    return matrices[k].GetValue(i, j - old_size);
                }
            }
            return 0;
        }

        public void SetValue(double chisl, int i, int j)
        {
            int size = 0, old_size = 0;
            for (int k = 0; k < matrices.Length; k++)
            {
                old_size = size;
                size += matrices[k].Column_count;
                if (size > i)
                {
                    if (matrices[k].Row_count < i)
                    {
                        return;
                    }
                    matrices[k].SetValue(chisl,i, j - old_size);
                }
            }
            return;
        }
    }
}
