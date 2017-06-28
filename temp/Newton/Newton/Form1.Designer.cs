namespace Newton
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ncol = new System.Windows.Forms.TextBox();
            this.Nrow = new System.Windows.Forms.TextBox();
            this.setTAB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtX = new System.Windows.Forms.TextBox();
            this.edtY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NY = new System.Windows.Forms.TextBox();
            this.NX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.AllowUserToResizeColumns = false;
            this.tab.AllowUserToResizeRows = false;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tab.ColumnHeadersVisible = false;
            this.tab.Location = new System.Drawing.Point(3, 58);
            this.tab.Name = "tab";
            this.tab.RowHeadersVisible = false;
            this.tab.RowHeadersWidth = 36;
            this.tab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tab.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tab.Size = new System.Drawing.Size(593, 224);
            this.tab.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rows";
            // 
            // Ncol
            // 
            this.Ncol.Location = new System.Drawing.Point(63, 4);
            this.Ncol.Name = "Ncol";
            this.Ncol.Size = new System.Drawing.Size(39, 20);
            this.Ncol.TabIndex = 3;
            this.Ncol.Text = "5";
            // 
            // Nrow
            // 
            this.Nrow.Location = new System.Drawing.Point(63, 32);
            this.Nrow.Name = "Nrow";
            this.Nrow.Size = new System.Drawing.Size(39, 20);
            this.Nrow.TabIndex = 4;
            this.Nrow.Text = "5";
            // 
            // setTAB
            // 
            this.setTAB.Location = new System.Drawing.Point(108, 4);
            this.setTAB.Name = "setTAB";
            this.setTAB.Size = new System.Drawing.Size(67, 49);
            this.setTAB.TabIndex = 5;
            this.setTAB.Text = "Initialize table";
            this.setTAB.UseVisualStyleBackColor = true;
            this.setTAB.Click += new System.EventHandler(this.setTAB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // edtX
            // 
            this.edtX.Location = new System.Drawing.Point(219, 5);
            this.edtX.Name = "edtX";
            this.edtX.Size = new System.Drawing.Size(40, 20);
            this.edtX.TabIndex = 8;
            // 
            // edtY
            // 
            this.edtY.Location = new System.Drawing.Point(219, 31);
            this.edtY.Name = "edtY";
            this.edtY.Size = new System.Drawing.Size(40, 20);
            this.edtY.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Result";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Location = new System.Drawing.Point(501, 7);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(85, 20);
            this.result.TabIndex = 12;
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.value.Location = new System.Drawing.Point(501, 33);
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Size = new System.Drawing.Size(85, 20);
            this.value.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Real value";
            // 
            // NY
            // 
            this.NY.Location = new System.Drawing.Point(291, 31);
            this.NY.Name = "NY";
            this.NY.Size = new System.Drawing.Size(40, 20);
            this.NY.TabIndex = 18;
            // 
            // NX
            // 
            this.NX.Location = new System.Drawing.Point(291, 5);
            this.NX.Name = "NX";
            this.NX.Size = new System.Drawing.Size(40, 20);
            this.NX.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ny";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 285);
            this.Controls.Add(this.NY);
            this.Controls.Add(this.NX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edtY);
            this.Controls.Add(this.edtX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setTAB);
            this.Controls.Add(this.Nrow);
            this.Controls.Add(this.Ncol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ncol;
        private System.Windows.Forms.TextBox Nrow;
        private System.Windows.Forms.Button setTAB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtX;
        private System.Windows.Forms.TextBox edtY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NY;
        private System.Windows.Forms.TextBox NX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

