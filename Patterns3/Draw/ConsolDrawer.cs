using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Draw
{
    class ConsolDrawer : IDrawer
    {
        private string matrix_in_str = "" ;
        private int size_col;
        private bool frame = false;

        public bool Frame { get => frame; set => frame = value; }

        public void DrawMatrix(IMatrix matrix)
        {
            if (frame)
            {
                DrawConsolLineFrame(size_col);
            }
            Console.WriteLine(matrix_in_str);
            matrix_in_str = "";
        }

        public void DrawFrame(IMatrix matrix)
        {
            if (frame)
            {
                size_col = matrix.Column_count;
            }
        }

        public void DrawConsolLineFrame(int size)
        {
            matrix_in_str += "\n ";
            for (int i = 0; i < size*7; i++)
            {
                this.matrix_in_str += "-";
            }
            matrix_in_str += "\n";
        }

        public void DrawCell(IMatrix matrix, int row, int col)
        {
            if ((col == 0) && (frame))
            {
                DrawConsolLineFrame(size_col);
                DrawVertConsolFrame();
            }
            bool SPCellFlag = (matrix.Strategy.GetCell(matrix, row, col) == String.Format("{0, -5:00.00}", ""));
            if (SPCellFlag)
            {
                DrawVertConsolFrame();
            }
            matrix_in_str += matrix.Strategy.GetCell(matrix, row, col);
            if (SPCellFlag)
            {
                DrawVertConsolFrame();
            }
            if ((col == size_col-1) && (frame))
            {
                DrawVertConsolFrame();
            }
        }
        public void DrawVertConsolFrame()
        {
            this.matrix_in_str += "|";
        }
    }
}
