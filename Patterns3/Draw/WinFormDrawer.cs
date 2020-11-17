using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Patterns3.Draw
{
    class WinFormDrawer : IDrawer
    {
        private Graphics graphics;
        private string matrix_in_str = "";

        public WinFormDrawer(Graphics graphics_)
        {
            graphics = graphics_;
        }
        public void DrawCell(double val, IMatrix matrix)
        {
            switch (matrix)
            {
                case SparseMatrix:
                    {
                        if (val == 0)
                        {
                            matrix_in_str += String.Format(" {0, -5:00.00} ", "");
                        }
                        else
                        {
                            matrix_in_str += String.Format("|{0,-4:00.00}|", val);
                        }
                        break;
                    }
                default:
                    matrix_in_str += String.Format("|{0,-4:00.00}|", val);
                    break;
            }
        }

        public void DrawFrame(int size)
        {
            matrix_in_str += "\n ";
            for (int i = 0; i < size*7; i++)
            {
                this.matrix_in_str += "-";
            }
            matrix_in_str += "\n";
        }

        public void DrawMatrix()
        {
            graphics.DrawString(matrix_in_str, new Font("Courier New", 10.0F), new SolidBrush(Color.Black), new Point(10, 10));
            matrix_in_str = "";
        }

        public void DrawGorFrame()
        {
            this.matrix_in_str += "|";
        }
    }
}
