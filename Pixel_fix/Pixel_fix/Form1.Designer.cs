namespace Pixel_fix
{
    partial class Pixel
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
            this.defaultBtn = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DX = new System.Windows.Forms.TextBox();
            this.DY = new System.Windows.Forms.TextBox();
            this.moveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Xdef = new System.Windows.Forms.TextBox();
            this.Ydef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Rdef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CY = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.timelb = new System.Windows.Forms.Label();
            this.timeX = new System.Windows.Forms.TextBox();
            this.timeYsf = new System.Windows.Forms.Label();
            this.timeY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultBtn
            // 
            this.defaultBtn.Location = new System.Drawing.Point(4, 93);
            this.defaultBtn.Name = "defaultBtn";
            this.defaultBtn.Size = new System.Drawing.Size(75, 27);
            this.defaultBtn.TabIndex = 0;
            this.defaultBtn.Text = "Default";
            this.defaultBtn.UseVisualStyleBackColor = true;
            this.defaultBtn.Click += new System.EventHandler(this.defaultBtn_Click);
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(85, 2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(590, 446);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            this.pBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "dX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "dY";
            // 
            // DX
            // 
            this.DX.Location = new System.Drawing.Point(36, 151);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(43, 20);
            this.DX.TabIndex = 5;
            this.DX.Text = "20";
            // 
            // DY
            // 
            this.DY.Location = new System.Drawing.Point(36, 173);
            this.DY.Name = "DY";
            this.DY.Size = new System.Drawing.Size(43, 20);
            this.DY.TabIndex = 6;
            this.DY.Text = "0";
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(3, 199);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(76, 26);
            this.moveBtn.TabIndex = 7;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Face position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y";
            // 
            // Xdef
            // 
            this.Xdef.Location = new System.Drawing.Point(30, 25);
            this.Xdef.Name = "Xdef";
            this.Xdef.Size = new System.Drawing.Size(49, 20);
            this.Xdef.TabIndex = 11;
            this.Xdef.Text = "200";
            // 
            // Ydef
            // 
            this.Ydef.Location = new System.Drawing.Point(30, 47);
            this.Ydef.Name = "Ydef";
            this.Ydef.Size = new System.Drawing.Size(49, 20);
            this.Ydef.TabIndex = 12;
            this.Ydef.Text = "150";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "R";
            // 
            // Rdef
            // 
            this.Rdef.Location = new System.Drawing.Point(30, 69);
            this.Rdef.Name = "Rdef";
            this.Rdef.Size = new System.Drawing.Size(49, 20);
            this.Rdef.TabIndex = 14;
            this.Rdef.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Set center";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "(resize/rotation)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "CX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "CY";
            // 
            // CY
            // 
            this.CY.Location = new System.Drawing.Point(30, 292);
            this.CY.Name = "CY";
            this.CY.Size = new System.Drawing.Size(49, 20);
            this.CY.TabIndex = 20;
            this.CY.Text = "240";
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(30, 270);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(49, 20);
            this.CX.TabIndex = 19;
            this.CX.Text = "350";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Angle";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(40, 400);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(39, 20);
            this.Angle.TabIndex = 22;
            this.Angle.Text = "180";
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(5, 421);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(75, 27);
            this.rotateBtn.TabIndex = 23;
            this.rotateBtn.Text = "Rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Location = new System.Drawing.Point(5, 361);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(75, 28);
            this.resizeBtn.TabIndex = 24;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // timelb
            // 
            this.timelb.AutoSize = true;
            this.timelb.Location = new System.Drawing.Point(6, 318);
            this.timelb.Name = "timelb";
            this.timelb.Size = new System.Drawing.Size(19, 13);
            this.timelb.TabIndex = 25;
            this.timelb.Text = "Kx";
            // 
            // timeX
            // 
            this.timeX.Location = new System.Drawing.Point(30, 314);
            this.timeX.Name = "timeX";
            this.timeX.Size = new System.Drawing.Size(49, 20);
            this.timeX.TabIndex = 26;
            this.timeX.Text = "2";
            // 
            // timeYsf
            // 
            this.timeYsf.AutoSize = true;
            this.timeYsf.Location = new System.Drawing.Point(6, 340);
            this.timeYsf.Name = "timeYsf";
            this.timeYsf.Size = new System.Drawing.Size(19, 13);
            this.timeYsf.TabIndex = 27;
            this.timeYsf.Text = "Ky";
            // 
            // timeY
            // 
            this.timeY.Location = new System.Drawing.Point(29, 336);
            this.timeY.Name = "timeY";
            this.timeY.Size = new System.Drawing.Size(50, 20);
            this.timeY.TabIndex = 28;
            this.timeY.Text = "1";
            // 
            // Pixel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.timeY);
            this.Controls.Add(this.timeYsf);
            this.Controls.Add(this.timeX);
            this.Controls.Add(this.timelb);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CY);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Rdef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ydef);
            this.Controls.Add(this.Xdef);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.DY);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.defaultBtn);
            this.Name = "Pixel";
            this.Text = "Pixels";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button defaultBtn;
        public System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DX;
        private System.Windows.Forms.TextBox DY;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Xdef;
        private System.Windows.Forms.TextBox Ydef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Rdef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CY;
        private System.Windows.Forms.TextBox CX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Label timelb;
        private System.Windows.Forms.TextBox timeX;
        private System.Windows.Forms.Label timeYsf;
        private System.Windows.Forms.TextBox timeY;
    }
}

