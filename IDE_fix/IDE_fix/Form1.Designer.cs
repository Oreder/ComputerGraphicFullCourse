namespace IDE_fix
{
    partial class IDE
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
            this.addBtn = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.editX = new System.Windows.Forms.TextBox();
            this.editY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.zoomBtn = new System.Windows.Forms.Button();
            this.unZoomBtn = new System.Windows.Forms.Button();
            this.proBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(165, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(480, 480);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(81, 218);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(78, 28);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.tab.Location = new System.Drawing.Point(4, 2);
            this.tab.Name = "tab";
            this.tab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tab.RowHeadersWidth = 30;
            this.tab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tab.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tab.Size = new System.Drawing.Size(155, 210);
            this.tab.TabIndex = 2;
            this.tab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_MouseClick);
            this.tab.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tab_MouseDoubleClick);
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 60;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // editX
            // 
            this.editX.Location = new System.Drawing.Point(21, 223);
            this.editX.Name = "editX";
            this.editX.Size = new System.Drawing.Size(54, 20);
            this.editX.TabIndex = 4;
            this.editX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editX_KeyDown);
            // 
            // editY
            // 
            this.editY.Location = new System.Drawing.Point(21, 249);
            this.editY.Name = "editY";
            this.editY.Size = new System.Drawing.Size(54, 20);
            this.editY.TabIndex = 6;
            this.editY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editY_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(81, 247);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(78, 27);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(81, 291);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(78, 49);
            this.solveBtn.TabIndex = 8;
            this.solveBtn.Text = "Solution";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // zoomBtn
            // 
            this.zoomBtn.Location = new System.Drawing.Point(81, 346);
            this.zoomBtn.Name = "zoomBtn";
            this.zoomBtn.Size = new System.Drawing.Size(78, 45);
            this.zoomBtn.TabIndex = 9;
            this.zoomBtn.Text = "Zoom";
            this.zoomBtn.UseVisualStyleBackColor = true;
            this.zoomBtn.Click += new System.EventHandler(this.zoomBtn_Click);
            // 
            // unZoomBtn
            // 
            this.unZoomBtn.Location = new System.Drawing.Point(81, 397);
            this.unZoomBtn.Name = "unZoomBtn";
            this.unZoomBtn.Size = new System.Drawing.Size(78, 46);
            this.unZoomBtn.TabIndex = 10;
            this.unZoomBtn.Text = "UnZoom";
            this.unZoomBtn.UseVisualStyleBackColor = true;
            this.unZoomBtn.Click += new System.EventHandler(this.unZoomBtn_Click);
            // 
            // proBtn
            // 
            this.proBtn.Location = new System.Drawing.Point(7, 291);
            this.proBtn.Name = "proBtn";
            this.proBtn.Size = new System.Drawing.Size(70, 49);
            this.proBtn.TabIndex = 11;
            this.proBtn.Text = "About";
            this.proBtn.UseVisualStyleBackColor = true;
            this.proBtn.Click += new System.EventHandler(this.proBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(7, 346);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(70, 45);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(7, 397);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 46);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // IDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 484);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.proBtn);
            this.Controls.Add(this.unZoomBtn);
            this.Controls.Add(this.zoomBtn);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.editY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.view);
            this.Name = "IDE";
            this.Text = "IDE";
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editX;
        private System.Windows.Forms.TextBox editY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button zoomBtn;
        private System.Windows.Forms.Button unZoomBtn;
        private System.Windows.Forms.Button proBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clear;
    }
}

