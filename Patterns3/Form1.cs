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

namespace Patterns3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        string last_f = "";
        SomeMatrix matrix;
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
        }

        private void bt_SimpMatr_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            if (last_f == "")
            {
                matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SimpMatr";
            }
            else if (matrix.GetType() == typeof(SimpleMatrix))
            {
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SimpMatr";
            }
            else
            {
                matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SimpMatr";
            }
        }

        private void bt_SpareMatr_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            if (last_f == "")
            {
                matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SpareMatr";
            }
            else if (matrix.GetType() == typeof(SparseMatrix))
            {
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SpareMatr";
            }
            else
            {
                matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                IDrawer drawer = new WinFormDrawer(graphics);
                matrix.Draw(drawer, checkBox1.Checked);
                last_f = "bt_SpareMatr";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
