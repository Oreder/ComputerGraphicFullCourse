namespace Lines
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.ColorPen = new System.Windows.Forms.PictureBox();
            this.ColorBackground = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.XBP = new System.Windows.Forms.TextBox();
            this.YBP = new System.Windows.Forms.TextBox();
            this.YEP = new System.Windows.Forms.TextBox();
            this.XEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radius = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.TextBox();
            this.axisBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(500, 300);
            this.view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.DisplayMember = "(none)";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "DDA",
            "Bresenham (double)",
            "Bresenham (int)",
            "Bresenham (intensity)",
            "Library function"});
            this.comboBox.Location = new System.Drawing.Point(506, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 1;
            this.comboBox.Tag = "";
            this.comboBox.ValueMember = "(none)";
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(539, 70);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 31);
            this.drawBtn.TabIndex = 2;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // ColorPen
            // 
            this.ColorPen.BackColor = System.Drawing.Color.Black;
            this.ColorPen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPen.Location = new System.Drawing.Point(515, 153);
            this.ColorPen.Name = "ColorPen";
            this.ColorPen.Size = new System.Drawing.Size(24, 24);
            this.ColorPen.TabIndex = 3;
            this.ColorPen.TabStop = false;
            this.ColorPen.Click += new System.EventHandler(this.ColorPen_Click);
            // 
            // ColorBackground
            // 
            this.ColorBackground.BackColor = System.Drawing.Color.White;
            this.ColorBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBackground.Location = new System.Drawing.Point(515, 183);
            this.ColorBackground.Name = "ColorBackground";
            this.ColorBackground.Size = new System.Drawing.Size(24, 24);
            this.ColorBackground.TabIndex = 4;
            this.ColorBackground.TabStop = false;
            this.ColorBackground.Click += new System.EventHandler(this.ColorBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pen color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Background";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose Algorithms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Beginning point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y";
            // 
            // XBP
            // 
            this.XBP.Location = new System.Drawing.Point(33, 335);
            this.XBP.Name = "XBP";
            this.XBP.Size = new System.Drawing.Size(59, 20);
            this.XBP.TabIndex = 11;
            this.XBP.Text = "0";
            // 
            // YBP
            // 
            this.YBP.Location = new System.Drawing.Point(33, 357);
            this.YBP.Name = "YBP";
            this.YBP.Size = new System.Drawing.Size(59, 20);
            this.YBP.TabIndex = 12;
            this.YBP.Text = "0";
            // 
            // YEP
            // 
            this.YEP.Location = new System.Drawing.Point(136, 357);
            this.YEP.Name = "YEP";
            this.YEP.Size = new System.Drawing.Size(59, 20);
            this.YEP.TabIndex = 17;
            this.YEP.Text = "100";
            // 
            // XEP
            // 
            this.XEP.Location = new System.Drawing.Point(136, 335);
            this.XEP.Name = "XEP";
            this.XEP.Size = new System.Drawing.Size(59, 20);
            this.XEP.TabIndex = 16;
            this.XEP.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "End point";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Draw Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.drC_Click);
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(576, 319);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(44, 20);
            this.radius.TabIndex = 19;
            this.radius.Text = "75";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(534, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Radius";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Angle";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(576, 345);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(44, 20);
            this.angle.TabIndex = 22;
            this.angle.Text = "30";
            // 
            // axisBtn
            // 
            this.axisBtn.Location = new System.Drawing.Point(302, 327);
            this.axisBtn.Name = "axisBtn";
            this.axisBtn.Size = new System.Drawing.Size(75, 34);
            this.axisBtn.TabIndex = 23;
            this.axisBtn.Text = "Show axis";
            this.axisBtn.UseVisualStyleBackColor = true;
            this.axisBtn.Click += new System.EventHandler(this.axisBtn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(539, 243);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 24;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.axisBtn);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YEP);
            this.Controls.Add(this.XEP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.YBP);
            this.Controls.Add(this.XBP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBackground);
            this.Controls.Add(this.ColorPen);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.PictureBox ColorPen;
        private System.Windows.Forms.PictureBox ColorBackground;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox XBP;
        private System.Windows.Forms.TextBox YBP;
        private System.Windows.Forms.TextBox YEP;
        private System.Windows.Forms.TextBox XEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Button axisBtn;
        private System.Windows.Forms.Button clear;
    }
}

