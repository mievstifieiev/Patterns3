using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Decorator
{
    class RenumDecorator : ADecorator
    {
        int[] rows;
        int[] columns;
        public RenumDecorator(IMatrix matrix):base(matrix)
        {
            if (matrix != null)
            {
                Cancel();
            }
        }

        public void RenumThis(int row1_, int row2_, int col1_, int col2_)
        {
            rows[row1_] = row2_;
            rows[row2_] = row1_;

            columns[col1_] = col2_;
            columns[col2_] = col1_;
        }

        public override void Cancel()
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
            return matrix.GetValue(rows[i], columns[j]);
        }

        public override void Draw(IDrawer drawer)
        {
            DrawFrame(drawer);
            DrawCells(drawer);
            DrawMatrix(drawer);
        }

        protected void DrawFrame(IDrawer drawer)
        {
            drawer.DrawFrame(this);
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
