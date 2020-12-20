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
using Patterns3.HGMatrix;

namespace Patterns3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        string last_f = "";
        IMatrix matrix;
        RenumDecorator renumDecorator;
        HGMatrix.HGMatrix gMatrix;
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
            WinFormDrawer drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer.Frame = checkBox1.Checked;
            if ((last_f == "") || !(matrix.GetType() == typeof(SimpleMatrix)))
            {
                matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                renumDecorator.Draw(drawer);

            }
            else if (matrix.GetType() == typeof(SimpleMatrix))
            {
                renumDecorator.Draw(drawer);

            }
            last_f = "bt_SimpMatr";
        }

        private void bt_SpareMatr_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            WinFormDrawer drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer.Frame = checkBox1.Checked;
            if ((last_f == "") || !(matrix.GetType() == typeof(SparseMatrix)))
            {
                matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                renumDecorator.Draw(drawer);
            }
            else if (matrix.GetType() == typeof(SparseMatrix))
            {
                renumDecorator.Draw(drawer);
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
                case "bt_Add_Simple_Click":
                    {
                        bt_Add_Simple_Click(sender, e);
                        break;
                    }
                case "bt_Add_Sparse_Click":
                    {
                        bt_Add_Sparse_Click(sender, e);
                        break;
                    }
                default:
                    break;
            }
        }

        private void bt_HGM_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            gMatrix = new HGMatrix.HGMatrix();
        }

        private void bt_Add_Simple_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
            InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
            gMatrix.SetMatrix(matrix);
            WinFormDrawer drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer.Frame = checkBox1.Checked;
            gMatrix.Draw(drawer);
            last_f = "bt_Add_Simple_Click";
        }

        private void bt_Add_Sparse_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
            InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
            gMatrix.SetMatrix(matrix);
            WinFormDrawer drawer = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer.Frame = checkBox1.Checked;
            gMatrix.Draw(drawer);
            last_f = "bt_Add_Sparse_Click";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            SwitchPrev(sender, e);
        }
    }
}
