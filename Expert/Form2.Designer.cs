namespace Expert
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pan_header_cycle = new System.Windows.Forms.Panel();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_cycle_container = new System.Windows.Forms.Panel();
            this.btnAddNewCycle = new System.Windows.Forms.Button();
            this.pan_cycle_main = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pan_header_cycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_cycle_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_header_cycle
            // 
            this.pan_header_cycle.BackColor = System.Drawing.Color.White;
            this.pan_header_cycle.Controls.Add(this.closeBox);
            this.pan_header_cycle.Controls.Add(this.panel1);
            this.pan_header_cycle.Controls.Add(this.pictureBox1);
            this.pan_header_cycle.Controls.Add(this.label1);
            this.pan_header_cycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header_cycle.Location = new System.Drawing.Point(0, 0);
            this.pan_header_cycle.Name = "pan_header_cycle";
            this.pan_header_cycle.Size = new System.Drawing.Size(950, 50);
            this.pan_header_cycle.TabIndex = 0;
            this.pan_header_cycle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_header_cycle_MouseDown);
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
            this.closeBox.TabIndex = 3;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
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
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(356, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Построение циклограммы";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pan_cycle_container
            // 
            this.pan_cycle_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pan_cycle_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.pan_cycle_container.Controls.Add(this.btnAddNewCycle);
            this.pan_cycle_container.Controls.Add(this.pan_cycle_main);
            this.pan_cycle_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_cycle_container.Location = new System.Drawing.Point(0, 50);
            this.pan_cycle_container.Name = "pan_cycle_container";
            this.pan_cycle_container.Size = new System.Drawing.Size(950, 490);
            this.pan_cycle_container.TabIndex = 1;
            // 
            // btnAddNewCycle
            // 
            this.btnAddNewCycle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewCycle.BackgroundImage")));
            this.btnAddNewCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewCycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewCycle.Location = new System.Drawing.Point(45, 6);
            this.btnAddNewCycle.Name = "btnAddNewCycle";
            this.btnAddNewCycle.Size = new System.Drawing.Size(166, 45);
            this.btnAddNewCycle.TabIndex = 0;
            this.btnAddNewCycle.UseVisualStyleBackColor = true;
            this.btnAddNewCycle.Click += new System.EventHandler(this.btnAddNewCycle_Click);
            // 
            // pan_cycle_main
            // 
            this.pan_cycle_main.AllowDrop = true;
            this.pan_cycle_main.AutoScroll = true;
            this.pan_cycle_main.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pan_cycle_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.pan_cycle_main.Location = new System.Drawing.Point(45, 57);
            this.pan_cycle_main.Name = "pan_cycle_main";
            this.pan_cycle_main.Size = new System.Drawing.Size(841, 363);
            this.pan_cycle_main.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 540);
            this.Controls.Add(this.pan_cycle_container);
            this.Controls.Add(this.pan_header_cycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.pan_header_cycle.ResumeLayout(false);
            this.pan_header_cycle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_cycle_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_header_cycle;
        private System.Windows.Forms.Panel pan_cycle_container;
        private System.Windows.Forms.Panel pan_cycle_main;
        private System.Windows.Forms.Button btnAddNewCycle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBox;
    }
}