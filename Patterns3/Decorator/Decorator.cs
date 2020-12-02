using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    abstract class Decorator : IMatrix
    {
        protected IMatrix matrix;

        public Decorator(IMatrix matrix_)
        {
            if (matrix_.GetType() == this.GetType())
            {
                return;
            }
            matrix = matrix_;
        }

        public void SetMatrix(IMatrix matrix_)
        {
            if (matrix_.GetType() != this.GetType())
            {
                matrix = matrix_;
            }
        }

        public int Row_count
        {
            get
            {
                if (matrix != null)
                {
                    return matrix.Row_count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Column_count
        {
            get
            {
                if (matrix != null)
                {
                    return matrix.Column_count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public IMatrix Matrix => matrix.Matrix;

        public virtual double GetValue(int i, int j)
        {
            if (matrix != null)
            {
                return matrix.GetValue(i, j);
            }
            else
            {
                return 0;
            }
        }

        public void SetValue(double chisl, int i, int j)
        {
            if (matrix != null)
            {
                matrix.SetValue(chisl, i, j);
            }
        }

        public abstract void Draw(IDrawer drawer, bool flag);
        protected abstract void DrawFrame(IDrawer drawer, bool flag);

        protected abstract void DrawCells(IDrawer drawer);

        protected abstract void DrawMatrix(IDrawer drawer);
    }
}
