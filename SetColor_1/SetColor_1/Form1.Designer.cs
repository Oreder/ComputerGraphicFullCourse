namespace SetColor_1
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.endP = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.listP = new System.Windows.Forms.ListBox();
            this.edtX = new System.Windows.Forms.TextBox();
            this.edtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.handAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(419, 369);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            this.view.MouseClick += new System.Windows.Forms.MouseEventHandler(this.view_MouseClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(512, 324);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(67, 41);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // endP
            // 
            this.endP.Location = new System.Drawing.Point(431, 324);
            this.endP.Name = "endP";
            this.endP.Size = new System.Drawing.Size(74, 41);
            this.endP.TabIndex = 4;
            this.endP.Text = "Close figure";
            this.endP.UseVisualStyleBackColor = true;
            this.endP.Click += new System.EventHandler(this.endP_Click);
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(431, 265);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(148, 53);
            this.Fill.TabIndex = 5;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // listP
            // 
            this.listP.FormattingEnabled = true;
            this.listP.Location = new System.Drawing.Point(447, 24);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(120, 134);
            this.listP.TabIndex = 6;
            // 
            // edtX
            // 
            this.edtX.Location = new System.Drawing.Point(26, 23);
            this.edtX.Name = "edtX";
            this.edtX.Size = new System.Drawing.Size(49, 20);
            this.edtX.TabIndex = 7;
            // 
            // edtY
            // 
            this.edtY.Location = new System.Drawing.Point(26, 49);
            this.edtY.Name = "edtY";
            this.edtY.Size = new System.Drawing.Size(49, 20);
            this.edtY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.handAdd);
            this.groupBox1.Controls.Add(this.edtX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(431, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Hand adding   ";
            // 
            // handAdd
            // 
            this.handAdd.Location = new System.Drawing.Point(81, 22);
            this.handAdd.Name = "handAdd";
            this.handAdd.Size = new System.Drawing.Size(55, 47);
            this.handAdd.TabIndex = 11;
            this.handAdd.Text = "Add";
            this.handAdd.UseVisualStyleBackColor = true;
            this.handAdd.Click += new System.EventHandler(this.handAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Coordinates figure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listP);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.endP);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.Text = "Set Color";
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button endP;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.ListBox listP;
        private System.Windows.Forms.TextBox edtX;
        private System.Windows.Forms.TextBox edtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button handAdd;
        private System.Windows.Forms.Label label3;
    }
}

