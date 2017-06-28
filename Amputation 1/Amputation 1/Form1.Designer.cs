namespace Amputation_1
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
            this.components = new System.ComponentModel.Container();
            this.view = new System.Windows.Forms.PictureBox();
            this.RightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.Button();
            this.choi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.RightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.ContextMenuStrip = this.RightMenu;
            this.view.Location = new System.Drawing.Point(1, 1);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(686, 416);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            this.view.MouseClick += new System.Windows.Forms.MouseEventHandler(this.view_MouseClick);
            // 
            // RightMenu
            // 
            this.RightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.RightMenu.Name = "contextMenuStrip1";
            this.RightMenu.Size = new System.Drawing.Size(130, 48);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(478, 423);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(182, 36);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // choi
            // 
            this.choi.FormattingEnabled = true;
            this.choi.Items.AddRange(new object[] {
            "Draw Rectangle",
            "Draw Line"});
            this.choi.Location = new System.Drawing.Point(97, 432);
            this.choi.Name = "choi";
            this.choi.Size = new System.Drawing.Size(217, 21);
            this.choi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choi);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.Text = "Amputation #1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.RightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox choi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip RightMenu;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}

