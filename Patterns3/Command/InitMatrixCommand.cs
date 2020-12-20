using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Draw;
using Patterns3.Decorator;
using System.Drawing;

namespace Patterns3.Command
{
    class InitMatrixCommand : ICommand
    {
        private IMatrix matrix1;
        private IDrawer drawer1;
        private ADecorator decorator1;
        private Graphics graphics1;

        public InitMatrixCommand(IMatrix matrix, IDrawer drawer, ADecorator decorator, Graphics graphics)
        {
            matrix1 = matrix;
            drawer1 = drawer;
            decorator1 = decorator;
            graphics1 = graphics;
        }

        public void Execute(ref IMatrix matrix, ref IDrawer drawer, ref ADecorator decorator, ref Graphics graphics)
        {
            matrix = matrix1;
            drawer = drawer1;
            decorator = decorator1;
            graphics = graphics1;
            decorator.Draw(drawer);
        }
    }
}
