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
            this.pan_header_cycle = new System.Windows.Forms.Panel();
            this.pan_cycle_container = new System.Windows.Forms.Panel();
            this.btnAddNewCycle = new System.Windows.Forms.Button();
            this.pan_cycle_main = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pan_cycle_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_header_cycle
            // 
            this.pan_header_cycle.BackColor = System.Drawing.Color.White;
            this.pan_header_cycle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header_cycle.Location = new System.Drawing.Point(0, 0);
            this.pan_header_cycle.Name = "pan_header_cycle";
            this.pan_header_cycle.Size = new System.Drawing.Size(948, 52);
            this.pan_header_cycle.TabIndex = 0;
            this.pan_header_cycle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_header_cycle_MouseDown);
            // 
            // pan_cycle_container
            // 
            this.pan_cycle_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pan_cycle_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.pan_cycle_container.Controls.Add(this.btnAddNewCycle);
            this.pan_cycle_container.Controls.Add(this.pan_cycle_main);
            this.pan_cycle_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_cycle_container.Location = new System.Drawing.Point(0, 52);
            this.pan_cycle_container.Name = "pan_cycle_container";
            this.pan_cycle_container.Size = new System.Drawing.Size(948, 487);
            this.pan_cycle_container.TabIndex = 1;
            // 
            // btnAddNewCycle
            // 
            this.btnAddNewCycle.Location = new System.Drawing.Point(45, 11);
            this.btnAddNewCycle.Name = "btnAddNewCycle";
            this.btnAddNewCycle.Size = new System.Drawing.Size(75, 36);
            this.btnAddNewCycle.TabIndex = 0;
            this.btnAddNewCycle.Text = "NewCycle";
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
            this.ClientSize = new System.Drawing.Size(948, 539);
            this.Controls.Add(this.pan_cycle_container);
            this.Controls.Add(this.pan_header_cycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
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

    }
}