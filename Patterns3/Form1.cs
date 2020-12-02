using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patterns3.Draw;
using Patterns3.Decorator;

namespace Patterns3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        string last_f = "";
        IMatrix matrix;
        RenumDecorator renumDecorator;
        IDrawer drawer;
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void bt_SimpMatr_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            if ((last_f == "") || !(matrix.GetType() == typeof(SimpleMatrix)))
            {
                matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                renumDecorator.Draw(drawer, checkBox1.Checked);

            }
            else if (matrix.GetType() == typeof(SimpleMatrix))
            {
                renumDecorator.Draw(drawer, checkBox1.Checked);

            }
            last_f = "bt_SimpMatr";
        }

        private void bt_SpareMatr_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            if ((last_f == "") || !(matrix.GetType() == typeof(SparseMatrix)))
            {
                matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                renumDecorator.Draw(drawer, checkBox1.Checked);
            }
            else if (matrix.GetType() == typeof(SparseMatrix))
            {
                renumDecorator.Draw(drawer, checkBox1.Checked);
            }
            last_f = "bt_SpareMatr";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            SwitchPrev(sender, e);
        }

        private void bt_Renum_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            renumDecorator.RenumThis(random.Next(0, renumDecorator.Row_count), random.Next(0, renumDecorator.Row_count), random.Next(0, renumDecorator.Column_count), random.Next(0, renumDecorator.Column_count));
            SwitchPrev(sender, e);
        }

        private void bt_Restore_Click(object sender, EventArgs e)
        {
            renumDecorator.CancelRenum();
            SwitchPrev(sender, e);
        }

        public void SwitchPrev(object sender, EventArgs e)
        {
            switch (last_f)
            {
                case "bt_SpareMatr":
                    {
                        bt_SpareMatr_Click(sender, e);
                        break;
                    };
                case "bt_SimpMatr":
                    {
                        bt_SimpMatr_Click(sender, e);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
