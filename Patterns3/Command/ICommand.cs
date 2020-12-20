using System;
using System.Collections.Generic;
using System.Text;
using Patterns3.Draw;
using Patterns3.Decorator;
using System.Drawing;

namespace Patterns3.Command
{
    interface ICommand
    {
        public void Execute(ref IMatrix matrix, ref IDrawer drawer, ref ADecorator decorator, ref Graphics graphics);
    }
}
