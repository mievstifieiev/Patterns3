using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    class RenumDecorator : Decorator
    {
        int[] rows;
        int[] columns;
        public RenumDecorator(IMatrix matrix):base(matrix)
        {
            CancelRenum();
        }

        public void RenumThis(int row1_, int row2_, int col1_, int col2_)
        {
            CancelRenum();
            rows[row1_] = row2_;
            rows[row2_] = row1_;

            columns[col1_] = col2_;
            columns[col2_] = col1_;
        }

        public void CancelRenum()
        {
            rows = new int[Row_count];
            for (int i = 0; i < Row_count; i++)
            {
                rows[i] = i;
            }

            columns = new int[Column_count];
            for (int i = 0; i < Column_count; i++)
            {
                columns[i] = i;
            }
        }

        public override double GetValue(int i, int j)
        {
            return Matrix.GetValue(rows[i], columns[j]);
        }

        protected override IVector Create(int co)
        {
            throw new NotImplementedException(); //заглушка, т.к. этот метод не используется в декораторе
        }
    }
}
