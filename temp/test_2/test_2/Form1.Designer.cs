namespace test_2
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
            this.clickBtn = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.CheckBox();
            this.resultBtn = new System.Windows.Forms.Button();
            this.switchBtn = new System.Windows.Forms.Button();
            this.arrBtn = new System.Windows.Forms.Button();
            this.stringBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickBtn
            // 
            this.clickBtn.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBtn.ForeColor = System.Drawing.Color.Crimson;
            this.clickBtn.Location = new System.Drawing.Point(250, 12);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(108, 42);
            this.clickBtn.TabIndex = 0;
            this.clickBtn.Text = "Click";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Visible = false;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            this.clickBtn.MouseHover += new System.EventHandler(this.clickBtn_MouseHover);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(138, 12);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(87, 29);
            this.show.TabIndex = 1;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(138, 48);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 26);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Checked = true;
            this.check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check.Location = new System.Drawing.Point(26, 54);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(47, 17);
            this.check.TabIndex = 4;
            this.check.Text = "Test";
            this.check.UseVisualStyleBackColor = true;
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(138, 80);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(87, 27);
            this.resultBtn.TabIndex = 5;
            this.resultBtn.Text = "Result";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // switchBtn
            // 
            this.switchBtn.Location = new System.Drawing.Point(26, 80);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(89, 27);
            this.switchBtn.TabIndex = 6;
            this.switchBtn.Text = "Switch";
            this.switchBtn.UseVisualStyleBackColor = true;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // arrBtn
            // 
            this.arrBtn.Location = new System.Drawing.Point(26, 114);
            this.arrBtn.Name = "arrBtn";
            this.arrBtn.Size = new System.Drawing.Size(89, 32);
            this.arrBtn.TabIndex = 7;
            this.arrBtn.Text = "Array";
            this.arrBtn.UseVisualStyleBackColor = true;
            this.arrBtn.Click += new System.EventHandler(this.arrBtn_Click);
            // 
            // stringBtn
            // 
            this.stringBtn.Location = new System.Drawing.Point(138, 113);
            this.stringBtn.Name = "stringBtn";
            this.stringBtn.Size = new System.Drawing.Size(81, 33);
            this.stringBtn.TabIndex = 8;
            this.stringBtn.Text = "String";
            this.stringBtn.UseVisualStyleBackColor = true;
            this.stringBtn.Click += new System.EventHandler(this.stringBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 150);
            this.Controls.Add(this.stringBtn);
            this.Controls.Add(this.arrBtn);
            this.Controls.Add(this.switchBtn);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.clickBtn);
            this.Name = "Form1";
            this.Text = "Button Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button switchBtn;
        private System.Windows.Forms.Button arrBtn;
        private System.Windows.Forms.Button stringBtn;
    }
}

