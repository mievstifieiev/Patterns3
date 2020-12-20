using Patterns3.Decorator;
using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Patterns3.Command
{
    class RenumCommand : ICommand
    {
        private ADecorator decorator1;
        public RenumCommand(RenumDecorator renum)
        {
            decorator1 = renum;
        }
        public void Execute(ref IMatrix matrix, ref IDrawer drawer, ref ADecorator decorator, ref Graphics graphics)
        {
            decorator = decorator1;
            decorator.Draw(drawer);
        }
    }
}
