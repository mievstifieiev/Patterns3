using Patterns3.Decorator;
using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Patterns3.Command
{
    class HGMCreateCommand : ICommand
    {
        private HGMatrix.HGMatrix gMatrix;
        public HGMCreateCommand()
        {
            gMatrix = new HGMatrix.HGMatrix();
        }
        public void Execute(ref IMatrix matrix, ref IDrawer drawer, ref ADecorator decorator, ref Graphics graphics)
        {
            gMatrix = new HGMatrix.HGMatrix();
            matrix = gMatrix;
        }
    }
}
