namespace Amputation_3
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
            this.radConfig = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.Execute = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.LineBox = new System.Windows.Forms.ListBox();
            this.ConfigList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(1, 2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(663, 418);
            this.view.TabIndex = 0;
            this.view.TabStop = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // radConfig
            // 
            this.radConfig.AutoSize = true;
            this.radConfig.Location = new System.Drawing.Point(25, 444);
            this.radConfig.Name = "radConfig";
            this.radConfig.Size = new System.Drawing.Size(118, 17);
            this.radConfig.TabIndex = 1;
            this.radConfig.TabStop = true;
            this.radConfig.Text = "Input configurations";
            this.radConfig.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(183, 444);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(73, 17);
            this.radLine.TabIndex = 2;
            this.radLine.TabStop = true;
            this.radLine.Text = "Input lines";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.SystemColors.Window;
            this.Execute.Location = new System.Drawing.Point(288, 425);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(145, 46);
            this.Execute.TabIndex = 3;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Window;
            this.clearBtn.Location = new System.Drawing.Point(473, 426);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(145, 46);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clear_Click);
            // 
            // LineBox
            // 
            this.LineBox.FormattingEnabled = true;
            this.LineBox.Location = new System.Drawing.Point(13, 492);
            this.LineBox.Name = "LineBox";
            this.LineBox.Size = new System.Drawing.Size(120, 95);
            this.LineBox.TabIndex = 5;
            // 
            // ConfigList
            // 
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(168, 492);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(120, 95);
            this.ConfigList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(665, 475);
            this.Controls.Add(this.ConfigList);
            this.Controls.Add(this.LineBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.radLine);
            this.Controls.Add(this.radConfig);
            this.Controls.Add(this.view);
            this.Name = "Form1";
            this.Text = "Amputation 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.RadioButton radConfig;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListBox LineBox;
        private System.Windows.Forms.ListBox ConfigList;
    }
}

