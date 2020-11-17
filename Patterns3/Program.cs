using Patterns3.Draw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SomeMatrix drawable = new SimpleMatrix(5, 5);
            SomeMatrix matrix = new SparseMatrix(5, 5);
            InitiatorMatrix.RandomMatr(drawable, 25, 25);
            InitiatorMatrix.RandomMatr(matrix, 5, 25);
            matrix.Draw(drawer, true);
            Console.WriteLine("");
            drawable.Draw(drawer, true);

            Application.Run(new Form1());
        }
    }
}
