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
        string emptyFormat = "{0, -5:00.00}", not_emptyFormat = "{0,-4:00.00}";
        List<Rectangle> rectangles = new List<Rectangle>();
        Pen myPenFrame;
        List<Point> pointsVal = new List<Point>();
        List<string> matrix_val = new List<string>();
        bool frameFlag = false;

        public WinFormDrawer(Graphics graphics_, Pen penFrame, int startX_ = 10, int startY_ = 10, int stepX_ = 60, int stepY_ = 60)
        {
            graphics = graphics_;
            startX = startX_;
            startY = startY_;
            stepX = stepX_;
            stepY = stepY_;
            myPenFrame = penFrame;
        }

        ~WinFormDrawer()
        {
            GC.SuppressFinalize(this);
        }

        public void DrawMatrix()
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
            rectangles.Add(new Rectangle(startX, startY, stepX * matrix.Column_count, stepY * matrix.Row_count));
            frameFlag = true;
        }

        public void DrawCell(IMatrix matrix, int row, int col)
        {
            matrix_val.Add(matrix.Strategy.GetCell(matrix,row,col));
            if (matrix.Strategy.GetCell(matrix,row,col) != String.Format("{0, -5:00.00}", ""))
            {
                if (frameFlag)
                {
                    rectangles.Add(new Rectangle(startX + stepX * row, startY + stepY * col, stepX, stepY));
                }
            }
            pointsVal.Add(new Point(startX + stepX * row, (stepY / 2)+ startY + stepY * col));
        }
    }
}
