using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Draw
{
    class ConsolDrawer:IDrawer
    {
        private string matrix_in_str = "" ;

        public string Matrix_in_str { get => matrix_in_str; set => matrix_in_str = value; }

        public void DrawMatrix()
        {
            Console.WriteLine(matrix_in_str);
            matrix_in_str = "";
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
        public void DrawGorFrame()
        {
            this.matrix_in_str += "|";
        }
    }
}
