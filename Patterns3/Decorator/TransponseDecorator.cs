using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Strategy;

namespace Patterns3.Decorator
{
    class TransponseDecorator : IMatrix
    {
        private IMatrix matrix;

        public double GetValue(int i, int j)
        {
            return matrix.GetValue(j, i);
        }

        public void SetValue(double chisl, int i, int j)
        {
            matrix.SetValue(chisl, j, i);
        }

        public void Draw(IDrawer drawer)
        {
            matrix.Draw(drawer);
        }

        public TransponseDecorator(HGMatrix.HGMatrix matrix_)
        {
            matrix = matrix_;
        }

        public IStrategy Strategy { get => matrix.Strategy; set => matrix.Strategy = value; }

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
    }
}
