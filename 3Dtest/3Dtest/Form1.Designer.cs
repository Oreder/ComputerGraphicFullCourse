namespace _3Dtest
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
            this.view = new System.Windows.Forms.PictureBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XminEdt = new System.Windows.Forms.TextBox();
            this.XmaxEdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dXedt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ZminEdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZmaxEdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dZedt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.funcList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.angleX = new System.Windows.Forms.NumericUpDown();
            this.angleY = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.angleZ = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleZ)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(166, 3);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(594, 441);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            // 
            // drawBtn
            // 
            this.drawBtn.BackColor = System.Drawing.Color.DarkGray;
            this.drawBtn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawBtn.Location = new System.Drawing.Point(12, 248);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(145, 76);
            this.drawBtn.TabIndex = 1;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = false;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X(min)";
            // 
            // XminEdt
            // 
            this.XminEdt.Location = new System.Drawing.Point(54, 12);
            this.XminEdt.Name = "XminEdt";
            this.XminEdt.Size = new System.Drawing.Size(100, 20);
            this.XminEdt.TabIndex = 3;
            this.XminEdt.Text = "-5";
            // 
            // XmaxEdt
            // 
            this.XmaxEdt.Location = new System.Drawing.Point(54, 38);
            this.XmaxEdt.Name = "XmaxEdt";
            this.XmaxEdt.Size = new System.Drawing.Size(100, 20);
            this.XmaxEdt.TabIndex = 5;
            this.XmaxEdt.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X(max)";
            // 
            // dXedt
            // 
            this.dXedt.Location = new System.Drawing.Point(54, 64);
            this.dXedt.Name = "dXedt";
            this.dXedt.Size = new System.Drawing.Size(100, 20);
            this.dXedt.TabIndex = 7;
            this.dXedt.Text = "0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "dX";
            // 
            // ZminEdt
            // 
            this.ZminEdt.Location = new System.Drawing.Point(54, 107);
            this.ZminEdt.Name = "ZminEdt";
            this.ZminEdt.Size = new System.Drawing.Size(100, 20);
            this.ZminEdt.TabIndex = 9;
            this.ZminEdt.Text = "-4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z(min)";
            // 
            // ZmaxEdt
            // 
            this.ZmaxEdt.Location = new System.Drawing.Point(54, 133);
            this.ZmaxEdt.Name = "ZmaxEdt";
            this.ZmaxEdt.Size = new System.Drawing.Size(100, 20);
            this.ZmaxEdt.TabIndex = 11;
            this.ZmaxEdt.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Z(max)";
            // 
            // dZedt
            // 
            this.dZedt.Location = new System.Drawing.Point(54, 159);
            this.dZedt.Name = "dZedt";
            this.dZedt.Size = new System.Drawing.Size(100, 20);
            this.dZedt.TabIndex = 13;
            this.dZedt.Text = "0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "dZ";
            // 
            // funcList
            // 
            this.funcList.FormattingEnabled = true;
            this.funcList.Items.AddRange(new object[] {
            "y = cos(x) * cos(z)",
            "y = sin(x) * z / 2",
            "y = cos(x + z)",
            "y = cos(x) + sin(z) * z",
            "y = sin(x) * cos(z) * x"});
            this.funcList.Location = new System.Drawing.Point(15, 221);
            this.funcList.Name = "funcList";
            this.funcList.Size = new System.Drawing.Size(139, 21);
            this.funcList.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Functions Y =  f(X, Z)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "angle X:";
            // 
            // angleX
            // 
            this.angleX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.angleX.Location = new System.Drawing.Point(73, 349);
            this.angleX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleX.Name = "angleX";
            this.angleX.Size = new System.Drawing.Size(81, 20);
            this.angleX.TabIndex = 17;
            this.angleX.ValueChanged += new System.EventHandler(this.angleX_ValueChanged);
            // 
            // angleY
            // 
            this.angleY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.angleY.Location = new System.Drawing.Point(73, 375);
            this.angleY.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleY.Name = "angleY";
            this.angleY.Size = new System.Drawing.Size(81, 20);
            this.angleY.TabIndex = 19;
            this.angleY.ValueChanged += new System.EventHandler(this.angleY_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "angle Y:";
            // 
            // angleZ
            // 
            this.angleZ.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.angleZ.Location = new System.Drawing.Point(73, 401);
            this.angleZ.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleZ.Name = "angleZ";
            this.angleZ.Size = new System.Drawing.Size(81, 20);
            this.angleZ.TabIndex = 21;
            this.angleZ.ValueChanged += new System.EventHandler(this.angleZ_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "angle Z:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(761, 447);
            this.Controls.Add(this.angleZ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.angleY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.angleX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.funcList);
            this.Controls.Add(this.dZedt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZmaxEdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ZminEdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dXedt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.XmaxEdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XminEdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.Text = "3D Hidden Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XminEdt;
        private System.Windows.Forms.TextBox XmaxEdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dXedt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ZminEdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ZmaxEdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dZedt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox funcList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown angleX;
        private System.Windows.Forms.NumericUpDown angleY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown angleZ;
        private System.Windows.Forms.Label label10;
    }
}

