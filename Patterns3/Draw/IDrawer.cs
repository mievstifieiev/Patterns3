using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns3.Draw
{
    interface IDrawer
    {
        public void DrawMatrix();

        public void DrawFrame(int size);

        public void DrawCell(double val, IMatrix matrix);

        public void DrawGorFrame();
    }
}
