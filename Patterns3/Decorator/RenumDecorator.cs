using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    class RenumDecorator : Decorator
    {
        int row1, row2, col1, col2;

        public RenumDecorator():base()
        {
            CancelRenum();
        }

        public void RenumThis(int row1_, int row2_, int col1_, int col2_)
        {
            row1 = row1_;
            row2 = row2_;
            col1 = col1_;
            col2 = col2_;
        }

        public void CancelRenum()
        {
            row1 = -1;
            row2 = -1;
            col1 = -1;
            col2 = -1;
        }

        public override double GetValue(int i, int j)
        {
            int newI, newJ;
            if (row1 == i)
            {
                newI = row2;
            }
            else if (row2 == i)
            {
                newI = row1;
            }
            else
            {
                newI = i;
            }
            if (col1 == j)
            {
                newJ = col2;
            }
            else if (col2 == j)
            {
                newJ = col1;
            }
            else
            {
                newJ = j;
            }
            return Matrix.GetValue(newI, newJ);
        }

        protected override IVector Create(int co)
        {
            throw new NotImplementedException(); //заглушка, т.к. этот метод не используется в декораторе
        }
    }
}
