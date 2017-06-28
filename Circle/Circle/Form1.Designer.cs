namespace Circle
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
            this.Color1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.Label();
            this.drawBtn = new System.Windows.Forms.Button();
            this.CX = new System.Windows.Forms.TextBox();
            this.CY = new System.Windows.Forms.TextBox();
            this.RA = new System.Windows.Forms.TextBox();
            this.CircleGbox = new System.Windows.Forms.GroupBox();
            this.Bedt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Aedt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.Cbox1 = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.axisBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Color2 = new System.Windows.Forms.PictureBox();
            this.RingBtn = new System.Windows.Forms.Button();
            this.Ringbox = new System.Windows.Forms.GroupBox();
            this.Redt = new System.Windows.Forms.TextBox();
            this.stepbox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.CircleGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Color2)).BeginInit();
            this.Ringbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.Color.Black;
            this.Color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color1.Location = new System.Drawing.Point(421, 127);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(23, 23);
            this.Color1.TabIndex = 0;
            this.Color1.TabStop = false;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(445, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color 1";
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 1);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(400, 400);
            this.view.TabIndex = 2;
            this.view.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CY";
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(80, 50);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(40, 13);
            this.radius.TabIndex = 5;
            this.radius.Text = "Radius";
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(406, 209);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(176, 49);
            this.drawBtn.TabIndex = 6;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(29, 47);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(46, 20);
            this.CX.TabIndex = 7;
            // 
            // CY
            // 
            this.CY.Location = new System.Drawing.Point(29, 71);
            this.CY.Name = "CY";
            this.CY.Size = new System.Drawing.Size(46, 20);
            this.CY.TabIndex = 8;
            // 
            // RA
            // 
            this.RA.Location = new System.Drawing.Point(124, 47);
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(38, 20);
            this.RA.TabIndex = 9;
            // 
            // CircleGbox
            // 
            this.CircleGbox.Controls.Add(this.Bedt);
            this.CircleGbox.Controls.Add(this.label4);
            this.CircleGbox.Controls.Add(this.Aedt);
            this.CircleGbox.Controls.Add(this.label5);
            this.CircleGbox.Controls.Add(this.CX);
            this.CircleGbox.Controls.Add(this.RA);
            this.CircleGbox.Controls.Add(this.radioE);
            this.CircleGbox.Controls.Add(this.label2);
            this.CircleGbox.Controls.Add(this.radioC);
            this.CircleGbox.Controls.Add(this.CY);
            this.CircleGbox.Controls.Add(this.label3);
            this.CircleGbox.Controls.Add(this.radius);
            this.CircleGbox.Location = new System.Drawing.Point(408, 9);
            this.CircleGbox.Name = "CircleGbox";
            this.CircleGbox.Size = new System.Drawing.Size(169, 104);
            this.CircleGbox.TabIndex = 10;
            this.CircleGbox.TabStop = false;
            this.CircleGbox.Text = "Input data";
            // 
            // Bedt
            // 
            this.Bedt.Location = new System.Drawing.Point(101, 71);
            this.Bedt.Name = "Bedt";
            this.Bedt.Size = new System.Drawing.Size(61, 20);
            this.Bedt.TabIndex = 26;
            this.Bedt.Text = "160";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "B";
            // 
            // Aedt
            // 
            this.Aedt.Location = new System.Drawing.Point(101, 47);
            this.Aedt.Name = "Aedt";
            this.Aedt.Size = new System.Drawing.Size(61, 20);
            this.Aedt.TabIndex = 24;
            this.Aedt.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "A";
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(101, 19);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(55, 17);
            this.radioE.TabIndex = 22;
            this.radioE.Text = "Ellipse";
            this.radioE.UseVisualStyleBackColor = true;
            this.radioE.CheckedChanged += new System.EventHandler(this.radioE_CheckedChanged);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(11, 19);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(51, 17);
            this.radioC.TabIndex = 21;
            this.radioC.Text = "Circle";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // Cbox1
            // 
            this.Cbox1.FormattingEnabled = true;
            this.Cbox1.Items.AddRange(new object[] {
            "Canonical form",
            "Parametric form",
            "Bresenham algorithm",
            "Midpoint algorithm",
            "Library function"});
            this.Cbox1.Location = new System.Drawing.Point(420, 182);
            this.Cbox1.Name = "Cbox1";
            this.Cbox1.Size = new System.Drawing.Size(132, 21);
            this.Cbox1.TabIndex = 10;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(407, 264);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(85, 39);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_Click);
            // 
            // axisBtn
            // 
            this.axisBtn.Location = new System.Drawing.Point(498, 264);
            this.axisBtn.Name = "axisBtn";
            this.axisBtn.Size = new System.Drawing.Size(85, 39);
            this.axisBtn.TabIndex = 13;
            this.axisBtn.Text = "Show axis";
            this.axisBtn.UseVisualStyleBackColor = true;
            this.axisBtn.Click += new System.EventHandler(this.axisBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Algorithms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(529, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Color 2";
            // 
            // Color2
            // 
            this.Color2.BackColor = System.Drawing.Color.White;
            this.Color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color2.Location = new System.Drawing.Point(505, 127);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(23, 23);
            this.Color2.TabIndex = 14;
            this.Color2.TabStop = false;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // RingBtn
            // 
            this.RingBtn.Location = new System.Drawing.Point(98, 19);
            this.RingBtn.Name = "RingBtn";
            this.RingBtn.Size = new System.Drawing.Size(72, 63);
            this.RingBtn.TabIndex = 16;
            this.RingBtn.Text = "Fill Rings";
            this.RingBtn.UseVisualStyleBackColor = true;
            this.RingBtn.Click += new System.EventHandler(this.RingBtn_Click);
            // 
            // Ringbox
            // 
            this.Ringbox.Controls.Add(this.Redt);
            this.Ringbox.Controls.Add(this.stepbox);
            this.Ringbox.Controls.Add(this.label9);
            this.Ringbox.Controls.Add(this.label11);
            this.Ringbox.Controls.Add(this.RingBtn);
            this.Ringbox.Location = new System.Drawing.Point(407, 313);
            this.Ringbox.Name = "Ringbox";
            this.Ringbox.Size = new System.Drawing.Size(176, 88);
            this.Ringbox.TabIndex = 17;
            this.Ringbox.TabStop = false;
            this.Ringbox.Text = "Concentric Rings";
            // 
            // Redt
            // 
            this.Redt.Location = new System.Drawing.Point(50, 27);
            this.Redt.Name = "Redt";
            this.Redt.Size = new System.Drawing.Size(42, 20);
            this.Redt.TabIndex = 28;
            this.Redt.Text = "150";
            // 
            // stepbox
            // 
            this.stepbox.Location = new System.Drawing.Point(51, 57);
            this.stepbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepbox.Name = "stepbox";
            this.stepbox.Size = new System.Drawing.Size(41, 20);
            this.stepbox.TabIndex = 18;
            this.stepbox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Radius";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Steps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 404);
            this.Controls.Add(this.Ringbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cbox1);
            this.Controls.Add(this.axisBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.CircleGbox);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.Color1);
            this.Name = "Form1";
            this.Text = "Circle & Ellipse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.CircleGbox.ResumeLayout(false);
            this.CircleGbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Color2)).EndInit();
            this.Ringbox.ResumeLayout(false);
            this.Ringbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Color1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label radius;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.TextBox CX;
        private System.Windows.Forms.TextBox CY;
        private System.Windows.Forms.TextBox RA;
        private System.Windows.Forms.GroupBox CircleGbox;
        private System.Windows.Forms.ComboBox Cbox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button axisBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Aedt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.TextBox Bedt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Color2;
        private System.Windows.Forms.Button RingBtn;
        private System.Windows.Forms.GroupBox Ringbox;
        private System.Windows.Forms.TextBox Redt;
        private System.Windows.Forms.NumericUpDown stepbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

