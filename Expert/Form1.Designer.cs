namespace Expert
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
            this.pan_left = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_main = new System.Windows.Forms.Panel();
            this.pan_cycle_list = new System.Windows.Forms.Panel();
            this.cycleList = new System.Windows.Forms.ListBox();
            this.pan_header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.pan_left.SuspendLayout();
            this.pan_main.SuspendLayout();
            this.pan_cycle_list.SuspendLayout();
            this.pan_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_left
            // 
            this.pan_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.pan_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_left.Controls.Add(this.button1);
            this.pan_left.Location = new System.Drawing.Point(0, 52);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(163, 445);
            this.pan_left.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-1, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "     New cycle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pan_main
            // 
            this.pan_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pan_main.Controls.Add(this.pan_cycle_list);
            this.pan_main.Location = new System.Drawing.Point(163, 52);
            this.pan_main.Name = "pan_main";
            this.pan_main.Size = new System.Drawing.Size(769, 445);
            this.pan_main.TabIndex = 2;
            this.pan_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_main_Paint);
            // 
            // pan_cycle_list
            // 
            this.pan_cycle_list.Controls.Add(this.cycleList);
            this.pan_cycle_list.Location = new System.Drawing.Point(45, 19);
            this.pan_cycle_list.Name = "pan_cycle_list";
            this.pan_cycle_list.Size = new System.Drawing.Size(243, 400);
            this.pan_cycle_list.TabIndex = 1;
            // 
            // cycleList
            // 
            this.cycleList.Location = new System.Drawing.Point(0, 0);
            this.cycleList.Name = "cycleList";
            this.cycleList.Size = new System.Drawing.Size(243, 134);
            this.cycleList.TabIndex = 0;
            // 
            // pan_header
            // 
            this.pan_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_header.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pan_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_header.Controls.Add(this.closeBox);
            this.pan_header.Controls.Add(this.panel1);
            this.pan_header.Cursor = System.Windows.Forms.Cursors.Default;
            this.pan_header.Location = new System.Drawing.Point(0, 0);
            this.pan_header.Name = "pan_header";
            this.pan_header.Size = new System.Drawing.Size(932, 52);
            this.pan_header.TabIndex = 0;
            this.pan_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_header_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackgroundImage = global::Expert.Properties.Resources._2_Flat_logo_on_transparent_274x75;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 52);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBox.Image = global::Expert.Properties.Resources.delete_cross;
            this.closeBox.Location = new System.Drawing.Point(900, 7);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(24, 24);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 2;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 497);
            this.Controls.Add(this.pan_main);
            this.Controls.Add(this.pan_left);
            this.Controls.Add(this.pan_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Expert";
            this.pan_left.ResumeLayout(false);
            this.pan_main.ResumeLayout(false);
            this.pan_cycle_list.ResumeLayout(false);
            this.pan_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_header;
        private System.Windows.Forms.Panel pan_left;
        private System.Windows.Forms.Panel pan_main;
        private System.Windows.Forms.Panel pan_cycle_list;
        private System.Windows.Forms.ListBox cycleList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox closeBox;
    }
}

