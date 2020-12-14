using Patterns3.Draw;
using Patterns3.Strategy;
using System;
using System.Collections.Generic;
using System.Text;


namespace Patterns3.HGMatrix
{
    class HGMatrix : IMatrix
    {
        private List<IMatrix> matrices = new List<IMatrix>();
        List<int> ls = new List<int>();
        private IStrategy strategy = new HGMStrategy();

        public int Row_count
        {
            get
            {
                int max = 0;
                foreach (var item in matrices)
                {
                    if (max < item.Row_count)
                    {
                        max = item.Row_count;
                    }
                }
                return max;
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

        public IStrategy Strategy { get => strategy; set => strategy = value; }

        public void Draw(IDrawer drawer, bool flag)
        {
            DrawFrame(drawer, flag);
            foreach (var item in matrices)
            {
                item.Draw(drawer, flag);
            }
        }

        public void SetMatrix(IMatrix matrix)
        {
            matrices.Add(matrix);
            if (ls.Count > 0)
            {
                ls.Add(ls[^1] + matrix.Column_count);
            }
            else
            {
                ls.Add(matrix.Column_count);
            }
        }

        protected void DrawFrame(IDrawer drawer, bool flag)
        {
            if (flag)
            {
                drawer.DrawFrame(this);
            }
        }

        //protected void DrawCells(IDrawer drawer)
        //{
        //    for (int i = 0; i < this.Row_count; i++)
        //    {
        //        for (int j = 0; j < this.Column_count; j++)
        //        {
        //            int size = 0;
        //            bool fl = true;
        //            for (int k = 0; k < matrices.Count; k++)
        //            {
        //                // old_size = size;
        //                size += matrices[k].Column_count;
        //                if (size >= j)
        //                {
        //                    if (matrices[k].Row_count-1 < i)
        //                    {
        //                        drawer.DrawCell(this, i, j);
        //                        fl = false;
        //                        break;
        //                    }
        //                    drawer.DrawCell(matrices[k], i, j);
        //                    fl = false;
        //                    break;
        //                }
        //            }
        //            if (fl)
        //            {
        //                drawer.DrawCell(this, i, j);
        //            }
        //        }
        //    }
        //}

        //protected void DrawMatrix(IDrawer drawer)
        //{
        //    drawer.DrawMatrix(this);
        //}

        public double GetValue(int i, int j)
        {
            int size = 0;
            for (int k = 0; k < matrices.Count; k++)
            {
                int old_size = size;
                size += matrices[k].Column_count;
                if (size>j)
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
            int size = 0;
            for (int k = 0; k < matrices.Count; k++)
            {
                int old_size = size;
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
