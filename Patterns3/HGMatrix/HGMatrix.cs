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
        private IStrategy strategy = new HGMStrategy();

        public virtual int Row_count
        {
            get
            {
                int max = 0;
                foreach (IMatrix item in matrices)
                {
                    if (max < item.Row_count)
                    {
                        max = item.Row_count;
                    }
                }
                return max;
            }
        }
        public virtual int Column_count
        {
            get
            {
                int size = 0;
                foreach (IMatrix item in matrices)
                {
                    size += item.Column_count;
                }

                return size;
            }
        }

        public virtual IStrategy Strategy { get => strategy; set => strategy = value; }

        public virtual void Draw(IDrawer drawer)
        {
            DrawFrame(drawer);
            DrawCells(drawer);
            DrawMatrix(drawer);
            
        }

        public void SetMatrix(IMatrix matrix)
        {
            matrices.Add(matrix);
        }

        private void DrawFrame(IDrawer drawer)
        {
            drawer.DrawFrame(this);
        }

        private void DrawCells(IDrawer drawer)
        {
            for (int i = 0; i < Row_count; i++)
            {
                for (int j = 0; j < Column_count; j++)
                {
                    int size = 0;
                    for (int k = 0; k < matrices.Count; k++)
                    {
                        size += matrices[k].Column_count;
                        if (size > j)
                        {
                            if (matrices[k].Row_count <= i)
                            {
                                strategy = new HGMStrategy();
                                drawer.DrawCell(this, i, j);
                                break;
                            }
                            strategy = matrices[k].Strategy;
                            drawer.DrawCell(this, i, j);
                            break;
                        }
                    }
                    strategy = new HGMStrategy();
                    drawer.DrawCell(this, i, j);

                }
            }
        }

        private void DrawMatrix(IDrawer drawer)
        {
            drawer.DrawMatrix(this);
        }

        public virtual double GetValue(int i, int j)
        {
            int size = 0;
            for (int k = 0; k < matrices.Count; k++)
            {
                int old_size = size;
                size += matrices[k].Column_count;
                if (size > j)
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

        public virtual void SetValue(double chisl, int i, int j)
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
                    matrices[k].SetValue(chisl, i, j - old_size);
                }
            }
            return;
        }
    }
}
