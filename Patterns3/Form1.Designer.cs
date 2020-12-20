namespace Patterns3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Col = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Row = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NoNull = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MaxVal = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bt_SimpMatr = new System.Windows.Forms.Button();
            this.bt_SpareMatr = new System.Windows.Forms.Button();
            this.bt_Renum = new System.Windows.Forms.Button();
            this.bt_Restore = new System.Windows.Forms.Button();
            this.bt_HGM = new System.Windows.Forms.Button();
            this.bt_Add_Simple = new System.Windows.Forms.Button();
            this.bt_Add_Sparse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 438);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размерность матрицы";
            // 
            // tb_Col
            // 
            this.tb_Col.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Col.Location = new System.Drawing.Point(546, 50);
            this.tb_Col.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Col.Name = "tb_Col";
            this.tb_Col.Size = new System.Drawing.Size(72, 23);
            this.tb_Col.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "на";
            // 
            // tb_Row
            // 
            this.tb_Row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Row.Location = new System.Drawing.Point(676, 50);
            this.tb_Row.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Row.Name = "tb_Row";
            this.tb_Row.Size = new System.Drawing.Size(53, 23);
            this.tb_Row.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество ненулевых элементов";
            // 
            // tb_NoNull
            // 
            this.tb_NoNull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NoNull.Location = new System.Drawing.Point(546, 111);
            this.tb_NoNull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_NoNull.Name = "tb_NoNull";
            this.tb_NoNull.Size = new System.Drawing.Size(110, 23);
            this.tb_NoNull.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальное значение элемента";
            // 
            // tb_MaxVal
            // 
            this.tb_MaxVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaxVal.Location = new System.Drawing.Point(549, 172);
            this.tb_MaxVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaxVal.Name = "tb_MaxVal";
            this.tb_MaxVal.Size = new System.Drawing.Size(110, 23);
            this.tb_MaxVal.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(685, 172);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Граница матрицы";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_SimpMatr
            // 
            this.bt_SimpMatr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SimpMatr.Location = new System.Drawing.Point(549, 196);
            this.bt_SimpMatr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SimpMatr.Name = "bt_SimpMatr";
            this.bt_SimpMatr.Size = new System.Drawing.Size(107, 53);
            this.bt_SimpMatr.TabIndex = 10;
            this.bt_SimpMatr.Text = "Нарисовать обычную матрицу";
            this.bt_SimpMatr.UseVisualStyleBackColor = true;
            this.bt_SimpMatr.Click += new System.EventHandler(this.bt_SimpMatr_Click);
            // 
            // bt_SpareMatr
            // 
            this.bt_SpareMatr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SpareMatr.Location = new System.Drawing.Point(676, 196);
            this.bt_SpareMatr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SpareMatr.Name = "bt_SpareMatr";
            this.bt_SpareMatr.Size = new System.Drawing.Size(110, 53);
            this.bt_SpareMatr.TabIndex = 12;
            this.bt_SpareMatr.Text = "Нарисовать разреженную матрицу";
            this.bt_SpareMatr.UseVisualStyleBackColor = true;
            this.bt_SpareMatr.Click += new System.EventHandler(this.bt_SpareMatr_Click);
            // 
            // bt_Renum
            // 
            this.bt_Renum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Renum.Location = new System.Drawing.Point(549, 254);
            this.bt_Renum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Renum.Name = "bt_Renum";
            this.bt_Renum.Size = new System.Drawing.Size(122, 27);
            this.bt_Renum.TabIndex = 13;
            this.bt_Renum.Text = "Перенумеровать";
            this.bt_Renum.UseVisualStyleBackColor = true;
            this.bt_Renum.Click += new System.EventHandler(this.bt_Renum_Click);
            // 
            // bt_Restore
            // 
            this.bt_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Restore.Location = new System.Drawing.Point(676, 254);
            this.bt_Restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Restore.Name = "bt_Restore";
            this.bt_Restore.Size = new System.Drawing.Size(125, 27);
            this.bt_Restore.TabIndex = 14;
            this.bt_Restore.Text = "Восстановить";
            this.bt_Restore.UseVisualStyleBackColor = true;
            this.bt_Restore.Click += new System.EventHandler(this.bt_Restore_Click);
            // 
            // bt_HGM
            // 
            this.bt_HGM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_HGM.Location = new System.Drawing.Point(549, 297);
            this.bt_HGM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_HGM.Name = "bt_HGM";
            this.bt_HGM.Size = new System.Drawing.Size(253, 22);
            this.bt_HGM.TabIndex = 15;
            this.bt_HGM.Text = "Создать группу матриц";
            this.bt_HGM.UseVisualStyleBackColor = true;
            this.bt_HGM.Click += new System.EventHandler(this.bt_HGM_Click);
            // 
            // bt_Add_Simple
            // 
            this.bt_Add_Simple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Add_Simple.Location = new System.Drawing.Point(549, 322);
            this.bt_Add_Simple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Add_Simple.Name = "bt_Add_Simple";
            this.bt_Add_Simple.Size = new System.Drawing.Size(122, 52);
            this.bt_Add_Simple.TabIndex = 16;
            this.bt_Add_Simple.Text = "Добавить простую матрицу";
            this.bt_Add_Simple.UseVisualStyleBackColor = true;
            this.bt_Add_Simple.Click += new System.EventHandler(this.bt_Add_Simple_Click);
            // 
            // bt_Add_Sparse
            // 
            this.bt_Add_Sparse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Add_Sparse.Location = new System.Drawing.Point(676, 323);
            this.bt_Add_Sparse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Add_Sparse.Name = "bt_Add_Sparse";
            this.bt_Add_Sparse.Size = new System.Drawing.Size(125, 52);
            this.bt_Add_Sparse.TabIndex = 17;
            this.bt_Add_Sparse.Text = "Добавить разреженную матрицу";
            this.bt_Add_Sparse.UseVisualStyleBackColor = true;
            this.bt_Add_Sparse.Click += new System.EventHandler(this.bt_Add_Sparse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 455);
            this.Controls.Add(this.bt_Add_Sparse);
            this.Controls.Add(this.bt_Add_Simple);
            this.Controls.Add(this.bt_HGM);
            this.Controls.Add(this.bt_Restore);
            this.Controls.Add(this.bt_Renum);
            this.Controls.Add(this.bt_SpareMatr);
            this.Controls.Add(this.bt_SimpMatr);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_MaxVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_NoNull);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Row);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Col);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Граница матрицы";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Col;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Row;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NoNull;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MaxVal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bt_SimpMatr;
        private System.Windows.Forms.Button bt_SpareMatr;
        private System.Windows.Forms.Button bt_Renum;
        private System.Windows.Forms.Button bt_Restore;
        private System.Windows.Forms.Button bt_HGM;
        private System.Windows.Forms.Button bt_Add_Simple;
        private System.Windows.Forms.Button bt_Add_Sparse;
    }
}

