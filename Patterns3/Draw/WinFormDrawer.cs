using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Patterns3.Draw
{
    class WinFormDrawer : IDrawer
    {
        private Graphics graphics;
        int startX, startY, stepX, stepY;
        List<Rectangle> rectangles = new List<Rectangle>();
        Pen myPenFrame;
        List<Point> pointsVal = new List<Point>();
        List<string> matrix_val = new List<string>();
        bool frameFlag = false;
        //List<IMatrix> matrices = new List<IMatrix>();

        public WinFormDrawer(Graphics graphics_, Pen penFrame, int startX_ = 10, int startY_ = 10, int stepX_ = 60, int stepY_ = 60)
        {
            graphics = graphics_;
            startX = startX_;
            startY = startY_;
            stepX = stepX_;
            stepY = stepY_;
            myPenFrame = penFrame;
        }

        public void DrawMatrix(IMatrix matrix)
        {
            if (rectangles.Count>0)
            {
                graphics.DrawRectangles(myPenFrame, rectangles.ToArray());
            }
            for (int i = 0; i < pointsVal.Count; i++)
            {
                graphics.DrawString(matrix_val[i], new Font("Courier New", 10.0F), new SolidBrush(Color.Black), pointsVal[i]);
            }
        }

        public void DrawFrame(IMatrix matrix)
        {
            rectangles.Add(new Rectangle(10, 10, stepX * matrix.Column_count, stepY * matrix.Row_count));
            frameFlag = true;
        }

        public void DrawCell(IMatrix matrix, int row, int col)
        {
            //int real_col = 0;
            //if (matrices.Count == 0)
            //{
            //    matrices.Add(matrix);
            //}
            //else if (col >= matrix.Column_count)
            //{
            //    real_col = col;
            //    int k = 0;
            //    while (real_col>=matrix.Column_count)
            //    {
            //        real_col -= matrices[k].Column_count;
            //        k++;
            //    }
            //    bool f = false;
            //    foreach (var item in matrices)
            //    {
            //        if (matrix == item)
            //        {
            //            f = true;
            //        }
            //    }
            //    if (!f)
            //    {
            //        matrices.Add(matrix);
            //    }
            //}
            matrix_val.Add(matrix.Strategy.GetCell(matrix, row, col));
            if (matrix.Strategy.GetCell(matrix, row, col) != string.Format("{0, -5:00.00}", ""))
            {
                if (frameFlag)
                {
                    rectangles.Add(new Rectangle(startX + (stepX * row), startY + (stepY * col), stepX, stepY));
                }
            }
            pointsVal.Add(new Point(startX + (stepX * row), (stepY / 2) + startY + (stepY * col)));
            if ((matrix.Column_count-1 == col)&&(matrix.Row_count-1 == row))
            {
                startX += matrix.Column_count * stepX;
            }
        }
    }
}
