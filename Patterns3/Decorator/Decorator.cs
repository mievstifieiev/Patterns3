using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Strategy;

namespace Patterns3.Decorator
{
    abstract class ADecorator : IMatrix
    {
        protected IMatrix matrix;

        public ADecorator(IMatrix matrix_)
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

        public virtual int Row_count
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

        public virtual int Column_count
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

        public IMatrix Matrix { get => matrix;}
        public IStrategy Strategy { get => matrix.Strategy; set => matrix.Strategy = value; }

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

        public abstract void Draw(IDrawer drawer);
    }
}
