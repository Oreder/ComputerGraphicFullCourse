namespace Amputation_4
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RectList = new System.Windows.Forms.ListBox();
            this.ConfigList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearA = new System.Windows.Forms.Button();
            this.clearC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 1);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(688, 403);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            this.view.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 424);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "(C) Input configuration";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 424);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "(A) Input rectangle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RectList
            // 
            this.RectList.FormattingEnabled = true;
            this.RectList.Location = new System.Drawing.Point(21, 477);
            this.RectList.Name = "RectList";
            this.RectList.Size = new System.Drawing.Size(120, 95);
            this.RectList.TabIndex = 3;
            // 
            // ConfigList
            // 
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(170, 478);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(120, 95);
            this.ConfigList.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Execute_Click);
            // 
            // ClearA
            // 
            this.ClearA.Location = new System.Drawing.Point(445, 410);
            this.ClearA.Name = "ClearA";
            this.ClearA.Size = new System.Drawing.Size(100, 45);
            this.ClearA.TabIndex = 6;
            this.ClearA.Text = "Clear (A)";
            this.ClearA.UseVisualStyleBackColor = true;
            this.ClearA.Click += new System.EventHandler(this.clearA_Click);
            // 
            // clearC
            // 
            this.clearC.Location = new System.Drawing.Point(566, 410);
            this.clearC.Name = "clearC";
            this.clearC.Size = new System.Drawing.Size(100, 45);
            this.clearC.TabIndex = 7;
            this.clearC.Text = "Clear (C)";
            this.clearC.UseVisualStyleBackColor = true;
            this.clearC.Click += new System.EventHandler(this.clearC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 458);
            this.Controls.Add(this.clearC);
            this.Controls.Add(this.ClearA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfigList);
            this.Controls.Add(this.RectList);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.Text = "Amputation 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox RectList;
        private System.Windows.Forms.ListBox ConfigList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearA;
        private System.Windows.Forms.Button clearC;
    }
}

