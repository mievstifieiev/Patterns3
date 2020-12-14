using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Draw
{
    interface IDrawer
    {
        public void DrawMatrix(IMatrix matrix);

        public void DrawFrame(IMatrix matrix);

        public void DrawCell(IMatrix matrix, int row, int col);
    }
}
