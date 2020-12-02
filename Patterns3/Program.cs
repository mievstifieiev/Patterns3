using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patterns3.Decorator;

namespace Patterns3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDrawer drawer = new ConsolDrawer();
            IMatrix drawable = new SimpleMatrix(5, 5);
            IMatrix matrix = new SparseMatrix(5, 5);
            InitiatorMatrix.RandomMatr(drawable, 25, 25);
            InitiatorMatrix.RandomMatr(matrix, 5, 25);
            matrix.Draw(drawer, true);
            Console.WriteLine("");
            drawable.Draw(drawer, true);
            RenumDecorator renum = new RenumDecorator(matrix);
            Random random = new Random();
            RenumDecorator renum1 = new RenumDecorator(renum);
            renum.SetMatrix(renum1);
            renum.RenumThis(random.Next(0, renum.Row_count), random.Next(0, renum.Row_count), random.Next(0, renum.Column_count), random.Next(0, renum.Column_count));
            renum1.RenumThis(random.Next(0, renum1.Row_count), random.Next(0, renum1.Row_count), random.Next(0, renum1.Column_count), random.Next(0, renum1.Column_count));
            renum1.Draw(drawer, true);


            Application.Run(new Form1());
        }
    }
}
