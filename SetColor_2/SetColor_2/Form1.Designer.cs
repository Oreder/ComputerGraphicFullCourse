namespace SetColor_2
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
            this.listP = new System.Windows.Forms.ListBox();
            this.view = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.handAdd = new System.Windows.Forms.Button();
            this.edtX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fill = new System.Windows.Forms.Button();
            this.endP = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.listCh = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radConfig = new System.Windows.Forms.RadioButton();
            this.radPO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listP
            // 
            this.listP.FormattingEnabled = true;
            this.listP.Location = new System.Drawing.Point(595, 29);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(120, 134);
            this.listP.TabIndex = 0;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 1);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(577, 471);
            this.view.TabIndex = 1;
            this.view.TabStop = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordinates Figure";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.handAdd);
            this.groupBox1.Controls.Add(this.edtX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edtY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(584, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 81);
            this.groupBox1.TabIndex = 12;
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
            // edtX
            // 
            this.edtX.Location = new System.Drawing.Point(26, 23);
            this.edtX.Name = "edtX";
            this.edtX.Size = new System.Drawing.Size(49, 20);
            this.edtX.TabIndex = 7;
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
            // edtY
            // 
            this.edtY.Location = new System.Drawing.Point(26, 49);
            this.edtY.Name = "edtY";
            this.edtY.Size = new System.Drawing.Size(49, 20);
            this.edtY.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(595, 279);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(206, 47);
            this.Fill.TabIndex = 15;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // endP
            // 
            this.endP.Location = new System.Drawing.Point(595, 346);
            this.endP.Name = "endP";
            this.endP.Size = new System.Drawing.Size(206, 46);
            this.endP.TabIndex = 14;
            this.endP.Text = "Close figure";
            this.endP.UseVisualStyleBackColor = true;
            this.endP.Click += new System.EventHandler(this.endP_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(595, 409);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(206, 41);
            this.ClearBtn.TabIndex = 13;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // listCh
            // 
            this.listCh.FormattingEnabled = true;
            this.listCh.Location = new System.Drawing.Point(721, 29);
            this.listCh.Name = "listCh";
            this.listCh.Size = new System.Drawing.Size(80, 82);
            this.listCh.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choose point";
            // 
            // radConfig
            // 
            this.radConfig.AutoSize = true;
            this.radConfig.Checked = true;
            this.radConfig.Location = new System.Drawing.Point(721, 120);
            this.radConfig.Name = "radConfig";
            this.radConfig.Size = new System.Drawing.Size(87, 17);
            this.radConfig.TabIndex = 18;
            this.radConfig.TabStop = true;
            this.radConfig.Text = "Configuration";
            this.radConfig.UseVisualStyleBackColor = true;
            // 
            // radPO
            // 
            this.radPO.AutoSize = true;
            this.radPO.Location = new System.Drawing.Point(721, 143);
            this.radPO.Name = "radPO";
            this.radPO.Size = new System.Drawing.Size(87, 17);
            this.radPO.TabIndex = 19;
            this.radPO.Text = "Choose point";
            this.radPO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 474);
            this.Controls.Add(this.radPO);
            this.Controls.Add(this.radConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listCh);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.endP);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.listP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listP;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button handAdd;
        private System.Windows.Forms.TextBox edtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button endP;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox listCh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radConfig;
        private System.Windows.Forms.RadioButton radPO;
    }
}

