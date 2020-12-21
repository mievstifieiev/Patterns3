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
        bool frame = false;

        public bool Frame { get => frame; set => frame = value; }

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
            matrix_val = new List<string>();
            pointsVal = new List<Point>();
            rectangles = new List<Rectangle>();
        }

        public void DrawFrame(IMatrix matrix)
        {
            if (frame)
            {
                rectangles.Add(new Rectangle(10, 10, stepX * matrix.Column_count, stepY * matrix.Row_count));
            }
        }

        public void DrawCell(IMatrix matrix, int row, int col)
        {
            matrix_val.Add(matrix.Strategy.GetCell(matrix, row, col));
            if (matrix.Strategy.GetCell(matrix, row, col) != string.Format("{0, -5:00.00}", ""))
            {
                if (frame)
                {
                    rectangles.Add(new Rectangle(startX + (stepX * col), startY + (stepY * row), stepX, stepY));
                }
            }
            pointsVal.Add(new Point(startX + (stepX * col), (stepY / 2) + startY + (stepY * row)));
        }
    }
}