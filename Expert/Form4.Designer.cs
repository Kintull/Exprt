namespace Expert
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minus_expert_button = new System.Windows.Forms.Button();
            this.plus_expert_button = new System.Windows.Forms.Button();
            this.expertListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 52);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackgroundImage = global::Expert.Properties.Resources._2_Flat_logo_on_transparent_274x75;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 52);
            this.panel5.TabIndex = 4;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 488);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(445, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 406);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.minus_expert_button);
            this.panel3.Controls.Add(this.plus_expert_button);
            this.panel3.Controls.Add(this.expertListBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(28, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 407);
            this.panel3.TabIndex = 1;
            // 
            // minus_expert_button
            // 
            this.minus_expert_button.BackgroundImage = global::Expert.Properties.Resources.minus;
            this.minus_expert_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minus_expert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_expert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus_expert_button.Location = new System.Drawing.Point(55, 52);
            this.minus_expert_button.Name = "minus_expert_button";
            this.minus_expert_button.Size = new System.Drawing.Size(30, 30);
            this.minus_expert_button.TabIndex = 3;
            this.minus_expert_button.UseVisualStyleBackColor = true;
            this.minus_expert_button.Click += new System.EventHandler(this.minus_expert_button_Click);
            this.minus_expert_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minus_expert_button_MouseDown);
            this.minus_expert_button.MouseEnter += new System.EventHandler(this.minus_expert_button_MouseEnter);
            this.minus_expert_button.MouseLeave += new System.EventHandler(this.minus_expert_button_MouseLeave);
            // 
            // plus_expert_button
            // 
            this.plus_expert_button.BackgroundImage = global::Expert.Properties.Resources.plus;
            this.plus_expert_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus_expert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_expert_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus_expert_button.Location = new System.Drawing.Point(19, 52);
            this.plus_expert_button.Name = "plus_expert_button";
            this.plus_expert_button.Size = new System.Drawing.Size(30, 30);
            this.plus_expert_button.TabIndex = 2;
            this.plus_expert_button.UseVisualStyleBackColor = true;
            this.plus_expert_button.Click += new System.EventHandler(this.plus_expert_button_Click);
            this.plus_expert_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plus_expert_button_MouseDown);
            this.plus_expert_button.MouseEnter += new System.EventHandler(this.plus_expert_button_MouseEnter);
            this.plus_expert_button.MouseLeave += new System.EventHandler(this.plus_expert_button_MouseLeave);
            this.plus_expert_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plus_expert_button_MouseUp);
            // 
            // expertListBox
            // 
            this.expertListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expertListBox.FormattingEnabled = true;
            this.expertListBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.expertListBox.IntegralHeight = false;
            this.expertListBox.ItemHeight = 25;
            this.expertListBox.Location = new System.Drawing.Point(19, 100);
            this.expertListBox.Name = "expertListBox";
            this.expertListBox.Size = new System.Drawing.Size(260, 260);
            this.expertListBox.TabIndex = 1;
            this.expertListBox.SelectedIndexChanged += new System.EventHandler(this.expertListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список экспертов";
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBox.Image = global::Expert.Properties.Resources.delete_cross;
            this.closeBox.Location = new System.Drawing.Point(914, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(24, 24);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 4;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button plus_expert_button;
        private System.Windows.Forms.ListBox expertListBox;
        private System.Windows.Forms.Button minus_expert_button;
        private System.Windows.Forms.PictureBox closeBox;
    }
}