using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    class TransponseDecorator : ADecorator
    {
        public override double GetValue(int i, int j)
        {
            return base.GetValue(j, i);
        }

        public TransponseDecorator(IMatrix matrix_) : base(matrix_)
        {
        }

        public override int Row_count
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

        public override int Column_count
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

        public override void Draw(IDrawer drawer, bool flag)
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
            drawer.DrawMatrix(this);
        }
    }
}
