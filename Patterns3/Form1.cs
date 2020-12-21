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
using Patterns3.Command;

namespace Patterns3
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        string last_f = "";
        IMatrix matrix;
        RenumDecorator renumDecorator;
        HGMatrix.HGMatrix gMatrix;
        List<ICommand> commands = new List<ICommand>();
        List<int> inits_comm_indx = new List<int>();
        int position = -1;
        IDrawer drawer;
        ADecorator Dec;
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
            WinFormDrawer drawer1 = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer1.Frame = checkBox1.Checked;
            drawer = drawer1;
            if ((last_f == "") || !(matrix.GetType() == typeof(SimpleMatrix)))
            {
                matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                Dec = renumDecorator;
                ICommand command = new InitMatrixCommand(matrix, drawer, Dec, graphics);
                command.Execute(ref matrix, ref drawer, ref Dec, ref graphics);
                position++;
                commands.Add(command);
                inits_comm_indx.Add(position);

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
            WinFormDrawer drawer1 = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer1.Frame = checkBox1.Checked;
            drawer = drawer1;
            if ((last_f == "") || !(matrix.GetType() == typeof(SparseMatrix)))
            {
                matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
                InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
                renumDecorator = new RenumDecorator(matrix);
                Dec = renumDecorator;
                ICommand command = new InitMatrixCommand(matrix, drawer, Dec, graphics );
                command.Execute(ref matrix,ref drawer,ref Dec, ref graphics);
                position++;
                commands.Add(command);
                inits_comm_indx.Add(position);
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
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            Random random = new Random();
            renumDecorator.RenumThis(random.Next(0, renumDecorator.Row_count), random.Next(0, renumDecorator.Row_count), random.Next(0, renumDecorator.Column_count), random.Next(0, renumDecorator.Column_count));
            Dec = renumDecorator;
            ICommand command = new RenumCommand(renumDecorator);
            command.Execute(ref matrix, ref drawer, ref Dec, ref graphics);
            commands.Add(command);
            position++;
            //SwitchPrev(sender, e);
        }

        private void bt_Restore_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            renumDecorator.Cancel();
            ICommand command = new CancelRenum();
            Dec = renumDecorator;
            command.Execute(ref matrix, ref drawer, ref Dec, ref graphics);
            commands.Add(command);
            position++;
            //SwitchPrev(sender, e);
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
            ICommand command = new HGMCreateCommand();
            position++;
            commands.Add(command);
            inits_comm_indx.Add(position);
        }

        private void bt_Add_Simple_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            matrix = new SimpleMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
            InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
            //gMatrix.SetMatrix(matrix);
            ICommand command = new HGMAddCommand(matrix);
            WinFormDrawer drawer1 = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer1.Frame = checkBox1.Checked;
            drawer = drawer1;
            matrix = gMatrix;
            if (Dec != null)
            {
                Dec.Cancel();
            }
            command.Execute(ref matrix, ref drawer, ref Dec, ref graphics);
            position++;
            commands.Add(command);
            //inits_comm_indx.Add(position);
            last_f = "bt_Add_Simple_Click";
        }

        private void bt_Add_Sparse_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            graphics = pictureBox1.CreateGraphics();
            matrix = new SparseMatrix(Convert.ToInt32(tb_Col.Text), Convert.ToInt32(tb_Row.Text));
            InitiatorMatrix.RandomMatr(matrix, Convert.ToInt32(tb_NoNull.Text), Convert.ToInt32(tb_MaxVal.Text));
            //gMatrix.SetMatrix(matrix);
            ICommand command = new HGMAddCommand(matrix);
            WinFormDrawer drawer1 = new WinFormDrawer(graphics, new Pen(Color.Red));
            drawer1.Frame = checkBox1.Checked;
            drawer = drawer1;
            matrix = gMatrix;
            if (Dec != null)
            {
                Dec.Cancel();
            }
            command.Execute(ref matrix, ref drawer, ref Dec, ref graphics);
            position++;
            commands.Add(command);
            //inits_comm_indx.Add(position);
            last_f = "bt_Add_Sparse_Click";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            SwitchPrev(sender, e);
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            if (position > -1)
            {
                //position--;
                commands.RemoveAt(commands.Count - 1);
                if (position == inits_comm_indx[inits_comm_indx.Count-1])
                {
                    inits_comm_indx.RemoveAt(inits_comm_indx.Count - 1);
                }
                position--;
                //inits_comm_indx.RemoveAt(inits_comm_indx.Count - 1);
            }
            for (int i = 0; i < inits_comm_indx.Count; i++)
            {
                if (position >= inits_comm_indx[inits_comm_indx.Count-i-1])
                {
                    for (int j = inits_comm_indx[inits_comm_indx.Count - i - 1]; j <= position; j++)
                    {
                        graphics.Clear(BackColor);

                        commands[j].Execute(ref matrix, ref drawer, ref Dec, ref graphics);
                        renumDecorator = Dec as RenumDecorator;
                        if (matrix is HGMatrix.HGMatrix)
                        {
                            gMatrix = matrix as HGMatrix.HGMatrix;
                        }
                    }
                    break;
                }
            }
        }
    }
}
