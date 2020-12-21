using Patterns3.Decorator;
using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Patterns3.Command
{
    class HGMAddCommand : ICommand
    {
        private IMatrix matrix1;
        private HGMatrix.HGMatrix gMatrix;
        public HGMAddCommand(IMatrix matrix)
        {
            matrix1 = matrix;
        }
        public void Execute(ref IMatrix matrix, ref IDrawer drawer, ref ADecorator decorator, ref Graphics graphics)
        {
            if (matrix is HGMatrix.HGMatrix)
            {
                gMatrix = matrix as HGMatrix.HGMatrix;
                gMatrix.SetMatrix(matrix1);
                matrix = gMatrix;
            }

            matrix.Draw(drawer);
        }
    }
}
