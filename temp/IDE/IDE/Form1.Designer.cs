namespace IDE
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editX = new System.Windows.Forms.TextBox();
            this.editY = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.DataGridView();
            this.tabX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionBtn = new System.Windows.Forms.Button();
            this.proBtn = new System.Windows.Forms.Button();
            this.zoomBtn = new System.Windows.Forms.Button();
            this.unzBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.drawBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(156, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // editX
            // 
            this.editX.Location = new System.Drawing.Point(18, 218);
            this.editX.Name = "editX";
            this.editX.Size = new System.Drawing.Size(57, 20);
            this.editX.TabIndex = 3;
            this.editX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editX_KeyDown);
            // 
            // editY
            // 
            this.editY.Location = new System.Drawing.Point(18, 248);
            this.editY.Name = "editY";
            this.editY.Size = new System.Drawing.Size(57, 20);
            this.editY.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(81, 213);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(69, 27);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(81, 244);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(69, 27);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // tab
            // 
            this.tab.AllowUserToAddRows = false;
            this.tab.AllowUserToDeleteRows = false;
            this.tab.AllowUserToResizeColumns = false;
            this.tab.AllowUserToResizeRows = false;
            this.tab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tab.ColumnHeadersHeight = 25;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tabX,
            this.tabY});
            this.tab.Location = new System.Drawing.Point(3, 3);
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tab.RowHeadersWidth = 25;
            this.tab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tab.Size = new System.Drawing.Size(147, 204);
            this.tab.TabIndex = 7;
            this.tab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tab_MouseClick);
            // 
            // tabX
            // 
            this.tabX.HeaderText = "X";
            this.tabX.Name = "tabX";
            this.tabX.ReadOnly = true;
            this.tabX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tabX.Width = 60;
            // 
            // tabY
            // 
            this.tabY.HeaderText = "Y";
            this.tabY.Name = "tabY";
            this.tabY.ReadOnly = true;
            this.tabY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tabY.Width = 60;
            // 
            // solutionBtn
            // 
            this.solutionBtn.Location = new System.Drawing.Point(81, 277);
            this.solutionBtn.Name = "solutionBtn";
            this.solutionBtn.Size = new System.Drawing.Size(69, 61);
            this.solutionBtn.TabIndex = 8;
            this.solutionBtn.Text = "Solution";
            this.solutionBtn.UseVisualStyleBackColor = true;
            this.solutionBtn.Click += new System.EventHandler(this.solutionBtn_Click);
            // 
            // proBtn
            // 
            this.proBtn.Location = new System.Drawing.Point(3, 374);
            this.proBtn.Name = "proBtn";
            this.proBtn.Size = new System.Drawing.Size(72, 30);
            this.proBtn.TabIndex = 9;
            this.proBtn.Text = "About";
            this.proBtn.UseVisualStyleBackColor = true;
            this.proBtn.Click += new System.EventHandler(this.proBtn_Click);
            // 
            // zoomBtn
            // 
            this.zoomBtn.Location = new System.Drawing.Point(81, 340);
            this.zoomBtn.Name = "zoomBtn";
            this.zoomBtn.Size = new System.Drawing.Size(69, 32);
            this.zoomBtn.TabIndex = 10;
            this.zoomBtn.Text = "Zoom";
            this.zoomBtn.UseVisualStyleBackColor = true;
            this.zoomBtn.Click += new System.EventHandler(this.zoomBtn_Click);
            // 
            // unzBtn
            // 
            this.unzBtn.Location = new System.Drawing.Point(81, 374);
            this.unzBtn.Name = "unzBtn";
            this.unzBtn.Size = new System.Drawing.Size(69, 31);
            this.unzBtn.TabIndex = 11;
            this.unzBtn.Text = "UnZoom";
            this.unzBtn.UseVisualStyleBackColor = true;
            this.unzBtn.Click += new System.EventHandler(this.unzBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(3, 309);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 32);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(3, 341);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(72, 31);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(3, 277);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(72, 29);
            this.drawBtn.TabIndex = 14;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 407);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.unzBtn);
            this.Controls.Add(this.zoomBtn);
            this.Controls.Add(this.proBtn);
            this.Controls.Add(this.solutionBtn);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editY);
            this.Controls.Add(this.editX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "IDE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editX;
        private System.Windows.Forms.TextBox editY;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabX;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabY;
        private System.Windows.Forms.Button solutionBtn;
        private System.Windows.Forms.Button proBtn;
        private System.Windows.Forms.Button zoomBtn;
        private System.Windows.Forms.Button unzBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button drawBtn;
    }
}

