using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    abstract class Decorator : SomeMatrix
    {
        private IMatrix matrix;

        public Decorator(IMatrix matrix_)
        {
            matrix = matrix_;
        }

        public void SetMatrix(IMatrix matrix_)
        {
            matrix = matrix_;
        }

        public override int Row_count => matrix.Row_count;

        public override int Column_count => matrix.Column_count;

        public override IMatrix Matrix => matrix;

        public override double GetValue(int i, int j)
        {
            return matrix.GetValue(i, j);
        }

        public override void SetValue(double chisl, int i, int j)
        {
            matrix.SetValue(chisl, i, j);
        }
    }
}
