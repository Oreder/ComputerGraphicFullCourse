namespace OleDb
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.browseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkedt = new System.Windows.Forms.TextBox();
            this.sheet = new System.Windows.Forms.TextBox();
            this.Resize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(326, 145);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(12, 12);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(70, 25);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_Click);
            // 
            // linkedt
            // 
            this.linkedt.Location = new System.Drawing.Point(88, 15);
            this.linkedt.Name = "linkedt";
            this.linkedt.Size = new System.Drawing.Size(251, 20);
            this.linkedt.TabIndex = 3;
            // 
            // sheet
            // 
            this.sheet.Location = new System.Drawing.Point(88, 60);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(112, 20);
            this.sheet.TabIndex = 4;
            this.sheet.Text = "Sheet1";
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(246, 59);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(75, 23);
            this.Resize.TabIndex = 5;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.linkedt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox linkedt;
        private System.Windows.Forms.TextBox sheet;
        private System.Windows.Forms.Button Resize;
    }
}

